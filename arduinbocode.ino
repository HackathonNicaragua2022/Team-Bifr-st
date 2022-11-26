//# include <SoftwareSerial.h>


int Trig = 12;
int Echo = 13;

 //softwareSerial mySerial(7,8);

void setup() {

 //mySerial.begin(9600);
 //mySerial.println("conexion exitosa");
 pinMode(Trig,OUTPUT);
 pinMode(Echo,INPUT);

  Serial.begin(9600);
  Serial.println("TEAM BIFROST");
 
  Serial.println("Bievenido");
  delay(2000);
 


}

void loop() {

   long duracion;
   long distancia;

  digitalWrite(Trig,LOW);
  delayMicroseconds(4);
  digitalWrite(Trig,HIGH);
  delayMicroseconds(10);
  digitalWrite(Trig,LOW);

  duracion = pulseIn(Echo,HIGH);
  duracion = duracion/2;

  distancia = duracion/29;

  

  if(distancia<=16 && distancia>=8){
  Serial.println("Nivel bajo");
   //mySerial.println("Nivel bajo");


  }
  if(distancia<7 && distancia>=3){
  Serial.println("Nivel Medio, tenga precaucion!!");
  // mySerial.println("Nivel Medio, tenga precaucion!!");

  }
  if(distancia<3 && distancia>= 1 ){
  Serial.println("Nivel Alto, Peligro!!! Busque Zona Segura!!");
   //mySerial.println("Nivel Alto, Peligro!!! Busque Zona Segura!!");
  }



  delay(100);
  
 }