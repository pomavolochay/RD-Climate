
//Define display pins
#include "SSD1306.h"
SSD1306  display(0x3C, D2, D1);
#include <Arduino.h>
#if defined(ESP32)
  #include <WiFi.h>
#elif defined(ESP8266)
  #include <ESP8266WiFi.h>
#endif
#include <Firebase_ESP_Client.h>
#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_BME280.h>

// Provide the token generation process info.
#include "addons/TokenHelper.h"
// Provide the RTDB payload printing info and other helper functions.
#include "addons/RTDBHelper.h"

// Insert your network credentials
#define WIFI_SSID "Insert the SSID of your WiFi network"
#define WIFI_PASSWORD "Paste the password for your WiFi network"

// Insert Firebase project API Key
#define API_KEY "Paste the Api key of the FireBase project"

// Insert Authorized Email and Corresponding Password
#define USER_EMAIL "Insert trusted mail"
#define USER_PASSWORD "Insert trusted mail password"

// Insert RTDB URLefine the RTDB URL
#define DATABASE_URL "Provide a link to FireBase Realtime"
// Define Firebase objects
FirebaseData fbdo;
FirebaseAuth auth;
FirebaseConfig config;

// Variable to save USER UID
String uid;

// Variables to save database paths
String databasePath;
String tempPath;
String humPath;
String presPath;

// BME280 sensor
Adafruit_BME280 bme; // I2C
float temperature;
float humidity;
float pressure;

// Timer variables (send new readings every three minutes)
unsigned long sendDataPrevMillis = 0;
unsigned long timerDelay = 5000;
// Fucktion for Displaying text
void displaySendText(int pointX, int pointY, String outText){
    display.flipScreenVertically();
    display.drawString(pointX, pointY, outText);
  }
// Initialize BME280
void initBME(){
  if (!bme.begin(0x76)) {
    Serial.println("Could not find a valid BME280 sensor, check wiring!");
    while (1);
  }
}

// Initialize WiFi
void initWiFi() {
  display.init(); // init display
   displaySendText(40,25, "RD Climate");
  display.display();
  delay(2000);
  WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
  Serial.print("Connecting to WiFi ..");
  display.clear();
  displaySendText(20,25, "Coonecting to Wifi");
  display.display();
  delay(2000);
  int i = 1;
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print('.');
    display.drawString(20 + i, 30, ".");
    display.display();
    delay(1000);
    i++;
  }
  Serial.println(WiFi.localIP());
  display.clear();
  displaySendText(20,25, "Connected to:");
  displaySendText(20,34, "roma_vol");
  display.display();
  Serial.println();
}

// Write float values to the database
void sendFloat(String path, float value){
  if (Firebase.RTDB.setFloat(&fbdo, path.c_str(), value)){
    Serial.print("Writing value: ");
    Serial.print (value);
    Serial.print(" on the following path: ");
    Serial.println(path);
    Serial.println("PASSED");
    Serial.println("PATH: " + fbdo.dataPath());
    Serial.println("TYPE: " + fbdo.dataType());
  }
  else {
    Serial.println("FAILED");
    Serial.println("REASON: " + fbdo.errorReason());
  }
}

void setup(){
  Serial.begin(115200);
  // Initialize BME280 sensor
  initBME();
  initWiFi();

  // Assign the api key (required)
  config.api_key = API_KEY;

  // Assign the user sign in credentials
  auth.user.email = USER_EMAIL;
  auth.user.password = USER_PASSWORD;

  // Assign the RTDB URL (required)
  config.database_url = DATABASE_URL;

  Firebase.reconnectWiFi(true);
  fbdo.setResponseSize(4096);

  // Assign the callback function for the long running token generation task */
  config.token_status_callback = tokenStatusCallback; //see addons/TokenHelper.h

  // Assign the maximum retry of token generation
  config.max_token_generation_retry = 5;

  // Initialize the library with the Firebase authen and config
  Firebase.begin(&config, &auth);

  // Getting the user UID might take a few seconds
  Serial.println("Getting User UID");
  while ((auth.token.uid) == "") {
    Serial.print('.');
    delay(1000);
  }
  // Print user UID
  uid = auth.token.uid.c_str();
  Serial.print("User UID: ");
  Serial.println(uid);

  // Update database path
  databasePath = "/UsersData/" + uid;

  // Update database path for sensor readings
  tempPath = databasePath + "/temperature"; // --> UsersData/<user_uid>/temperature
  humPath = databasePath + "/humidity"; // --> UsersData/<user_uid>/humidity
  presPath = databasePath + "/pressure"; // --> UsersData/<user_uid>/pressure
  
}

void loop(){
  // Send new readings to database
  if (Firebase.ready() && (millis() - sendDataPrevMillis > timerDelay || sendDataPrevMillis == 0)){
    sendDataPrevMillis = millis();

    // Get latest sensor readings
    temperature = bme.readTemperature() - 5;
    humidity = bme.readHumidity();
    pressure = bme.readPressure()/100.0F;
    String temp = String(temperature);
    String hum = String(humidity);
    String pres = String(pressure);
    display.clear();
    displaySendText(10,15, "FireBase: connected");
    displaySendText(10,25, "temp |");
    display.drawString(42, 25, temp);
    displaySendText(70,25, "C");
    displaySendText(10,35, "hum |");
    display.drawString(40, 35, hum);
    displaySendText(70,35, "%");
    displaySendText(10,45, "press |");
    display.drawString(42, 45, pres);
    displaySendText(83,45, "hPa");
    display.display();
    // Send readings to database:
    sendFloat(tempPath, temperature);
    sendFloat(humPath, humidity);
    sendFloat(presPath, pressure);
  }
}
