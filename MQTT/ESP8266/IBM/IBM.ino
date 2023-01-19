#include <ESP8266WiFi.h>
#include <PubSubClient.h>
//-------- Customise these values -----------
const char* ssid = "p701";
const char* password = "phong701!@#";


#define DEVICE_TYPE "ESP8266"
#define DEVICE_ID   "5CCF7F16E1CF"
#define TOKEN       "KxciqN4cZ4m@nO0t46"
//-------- Customise the above values --------
void callback(char* topic, byte* payload, unsigned int len);

char server[]=      "ctxa6g.messaging.internetofthings.ibmcloud.com";
char pubtopic[] =   "iot-2/evt/MyESP/fmt/json";
char subtopic[] =   "iot-2/cmd/MyESP/fmt/String";
char user[]  =      "use-token-auth";
char pass[]  =      TOKEN;
char id[]    =      "d:ctxa6g:" DEVICE_TYPE ":" DEVICE_ID;

WiFiClient wifiClient;
PubSubClient client(server, 1883, callback, wifiClient);

void setup() 
{
  Serial.begin(115200);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
  }
  MQTTConnect();
 
}

void loop() 
{
  if (!client.loop()) 
  {
    MQTTConnect();
  }
  SerialRead();
}




void MQTTConnect() {
  if (!client.connected()) 
  {
    while (!client.connect(id, user, pass)) 
    {
      delay(500);
    }
    client.subscribe(subtopic);
   
  }
}

void SerialRead()
{
  if(Serial.available()==3)
  {
    String data = Serial.readString();
    char data_array[3];
    data.toCharArray(data_array,4);
    //Xu li LED
    if(data_array[0]=='@')
    {
       String payload = "{";
       payload += "\"Name\":";
       payload += "\"LED\"";
       payload += ",\"Status\":";
       payload += (byte)data_array[1];
       payload += "}";
       client.publish(pubtopic, (char*) payload.c_str());
    }
    //Xu li cam bien
    if(data_array[0]=='#')
    {
       String payload = "{"; 
       payload += "\"Name\":";
       payload += "\"DHT\"";
       payload += ",\"Temperature\":";
       payload += (byte)data_array[1];
       payload += ",\"Humidity\":";
       payload += (byte)data_array[2];
       payload += "}";
       client.publish(pubtopic, (char*) payload.c_str());
    }
}
}
void callback(char* topic, byte* payload, unsigned int len) 
{
 
    Serial.print((char)payload[0]);
    Serial.print((char)payload[1]);

}
