## THE STATE PATTERN

_Allow an object to alter its behavior when its internal state changes. The object will appear to change its class._

### Problema

Um semáforo tem um temporizador que emite impulsos a intervalos regulares. Estes impulsos chegam ao controlador do semáforo sob a forma de chamadas ao método `Tick`. Em funcionamento normal, um tick faz com que o semáforo passe da cor vermelha para a verde, da verde para a amarela e da amarela para a vermelha, reiniciando o ciclo. 

O semáforo tem ainda vários botões para controlo de situações especiais. Assim, o botão de pânico que faz com que o controlador mude o semáforo para a cor vermelha, qualquer que seja a anterior (método `Panic`). O botão off faz com que o semáforo mude imediatamente para amarelo intermitente (método `Off`). Esta situação é interrompida através dos botões on que volta ao comportamento normal (método `On`) ou de pânico. O botão on é a única forma de fazer o semáforo sair da situação de pânico e recuperar o funcionamento normal. O semáforo começa intermitente e quando recupera das situações de intermitência e de pânico fica vermelho.

Implemente o semáforo e a sua máquina de estados.

#### Exemplo

```txt
Light status: Blinking
[Blinking] --(off)-> [Blinking]
[Blinking] --(panic)-> [Panic]
[Panic] --(on)-> [Red]
[Red] --(tick)-> [Green]
[Green] --(tick)-> [Yellow]
[Yellow] --(tick)-> [Red]
[Red] --(tick)-> [Green]
[Green] --(panic)-> [Panic]
[Panic] --(off)-> [Panic]
[Panic] --(on)-> [Red]
[Red] --(off)-> [Blinking]
```