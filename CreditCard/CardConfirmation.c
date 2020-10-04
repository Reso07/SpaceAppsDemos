#include <MFRC522.h>
#include <Servo.h>
#include <SPI.h>
int revort = 0;
int rstPin = 9, ssPin = 10, servoPin = 8;
bool durum = false;
Servo motor;
MFRC522 rfid(ssPin, rstPin);
byte id[4] = {185, 10, 59, 142};
void setup() {
  motor.attach(servoPin);
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
}

void loop() {
  if (!rfid.PICC_IsNewCardPresent() || !rfid.PICC_ReadCardSerial()) {
    delay(50);
    return;
  }
  for (int i = 0; i < 4; i++)
  {
    if (rfid.uid.uidByte[i] != id[i])
    {
      durum = false;
      break;
    }
    durum = true;
  }
  if (durum)
  {
    Serial.println("Giriş Başarılı");
    motor.write(180);
    delay(3000);
    motor.write(0);
    delay(1000);
    revort += 5;	
  }
  else
  {
    Serial.println("Giriş Başarısız");
  }
  rfid.PICC_HaltA();
}
