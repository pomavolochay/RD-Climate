#include "DHT11.h"

extern DHT11 MyDHT;

DHTSetup DHTInit;
void DHT_Init(TIM_HandleTypeDef timcap,
							DMA_HandleTypeDef dmacap,
							TIM_HandleTypeDef timdelay,
							UART_HandleTypeDef uart
							)
{
		DHTInit.TIM_Capture=timcap;
		DHTInit.DMA_Capture=dmacap;
		DHTInit.TIM_Delay=timdelay;
		DHTInit.UART=uart;
		DHT_Start();
		HAL_TIM_Base_Start_IT(&DHTInit.TIM_Delay);

}
void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim)
{
		if (htim->Instance==DHTInit.TIM_Delay.Instance)
		{
				DHT_Start();
		}
}
void HAL_TIM_IC_CaptureCallback(TIM_HandleTypeDef *htim)
{
	if (htim->Instance==DHTInit.TIM_Capture.Instance)
	{
		HAL_TIM_IC_Stop_DMA(&DHTInit.TIM_Capture,TIM_CHANNEL_2);
		DHT_Read(MyDHT.data,MyDHT.rawdata);
		HAL_GPIO_TogglePin(GPIOD,GPIO_PIN_15);
	}
}
void DHT_Read(uint8_t *_decode,uint32_t* _data)
{

	 for (int pos = 0; pos < 40; pos++) 
		{
          
            if (_data[pos+2] > 100) 
						{
                _decode[pos / 8] |= 1 <<(7-(pos % 8));      //Bit 1
					
            } 
							else 
						{
                _decode[pos / 8] &= ~(1 << (7-(pos % 8)));   //Bit 0
         
						}		
		}
		//Check Error
		if(_decode[0]+_decode[2]==_decode[4])
		{
			MyDHT.humidity=_decode[0];
			MyDHT.temperature=_decode[2];
		}

}
void DHT_Start(void)
{
	GPIO_InitTypeDef GPIO_InitStruct;
	GPIO_InitStruct.Pin = GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_VERY_HIGH;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
	HAL_GPIO_WritePin(GPIOA,GPIO_PIN_1,0);
  HAL_Delay(20);
  GPIO_InitStruct.Pin = GPIO_PIN_1;
  GPIO_InitStruct.Mode = GPIO_MODE_AF_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_VERY_HIGH;
  GPIO_InitStruct.Alternate = GPIO_AF1_TIM2;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
  HAL_TIM_IC_Start_DMA(&DHTInit.TIM_Capture,TIM_CHANNEL_2,MyDHT.rawdata,42);

}