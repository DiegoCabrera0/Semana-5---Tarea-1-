int pinAlarma = 8;

void setup() {
  Serial.begin(9600);
  pinMode(pinAlarma, OUTPUT);
}

void loop() {
  if (Serial.available()) {
    char comando = Serial.read();
    if (comando == '1') {
      digitalWrite(pinAlarma, HIGH); // Encender alarma
    } else if (comando == '0') {
      digitalWrite(pinAlarma, LOW); // Apagar alarma
    }
  }
}
