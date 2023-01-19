#ifndef _DHT11_H
#define _DHT11_H
#include "stm32f4xx_hal.h"



typedef struct DHT11{
	uint8_t 	temperature;
	uint8_t	  humidity;
	uint8_t 	data[5];
	uint32_t 	rawdata[42];
	uint8_t 	error;
} DHT11;

typedef struct DHTSetup
{
	TIM_HandleTypeDef TIM_Capture;
  DMA_HandleTypeDef DMA_Capture;
  TIM_HandleTypeDef TIM_Delay;
  UART_HandleTypeDef UART;
	GPIO_TypeDef PORT;
	uint16_t PIN;
}DHTSetup;
void DHT_Init(TIM_HandleTypeDef timcap,
							DMA_HandleTypeDef dmacap,
							TIM_HandleTypeDef timdelay,
							UART_HandleTypeDef uart
							);
void DHT_Read(uint8_t *_decode,uint32_t* _data);
void DHT_Start(void);

#endif