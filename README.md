## Објаснување на играта:

Оваа игра е инспирирана од повеќе ритамски игри како [Dance Dance Revolution](https://en.wikipedia.org/wiki/Dance_Dance_Revolution) и [Friday night Funkin](https://en.wikipedia.org/wiki/Friday_Night_Funkin%27). Целта на играта е да се провери издржливоста на играчот со тоа што од горниот дел на прозорецот паѓа неограничен број на ноти. Играчот треба да погоди што е можно повеќе ноти без да се промашат премногу.


## Упатство за играње:
Играта е многу едноставна, од горниот дел на прозорецот паѓаат ноти кон разнобојни стрелки. Кога некоја нота ќе биде покриена од некоја стрелка, потребно е да се кликне копчето на соодветната стрелка на тастатурата, со што ќе се погоди нотата. Една нота може да биде погодена на три различни начини: „Совршено“, „Добро“, „Лошо“, во зависност од тоа колку е покриена од стрелката.

* Ако нотата е целосно покриена од стрелката, тоа е „совршен“ погодок и носи најмногу поени. (1.5)
* Ако поголем дел од нотата е покриен од стрелката или ако малку се задоцни со клик после покривањето на нотата со стрелка, тоа е „добар“ погодок и носи нормален број на поени. (1)
* Ако само мал дел од нотата е покриен од стрелката или ако многу се задоцни со клик после покривањето на нотата со стрелка, тоа е „лош“ погодок и носи помал број на поени. (0.5)


Покрај ова, ако воопшто не се кликне на некоја нота после покривање со стрелка, тогаш ова се смета како промашена нота и одзима 0.5 поени. Максималниот број на дозволени промашени ноти е 29. На 30 промашувања играта завршува, се пресметува добиениот резултат како збир од сите погодоци и се враќа на главното мени. Една игра неможе да се прекине со рачно исклучување на прозорецот. Во тој случај играта се поништува и се отфрлаат добиените поени. 


## Објаснување на кодот:
Играта е целосно е направена од почеток, без користење на туѓа, веќе постоечка имплементација. На почетниот екран се прикажува копче за старт на играта, листа од сите резултати освоени во сегашната сесија, како и највисокиот постигнат резултат. По клик на старт копчето веднаш започнува играта. Во кодот има класа за секоја поединечна нота, а сите типови на ноти (ноти од една иста боја) се чуваат во посебна листа со цел поедноставна да биде проверката за погодок. Сите информации поврзани со играта се наоѓаат во класата [Scene](https://github.com/BorisTodor0v/VP/blob/main/Rhythm%20Game/Scene.cs). Во неа се сместени бројот на различните типови на погодоци како и функции за генерирање и исцртување на нотите, како и проверка за промашени ноти.


Во кодот се објаснети променливите, фунцкиите и постапките за да се добие саканиот резултат што е можно подетално. Како пример може да се земе [Game](https://github.com/BorisTodor0v/VP/blob/main/Rhythm%20Game/Game.cs) формата каде има објаснување за секоја функција.

## Слики од играта

Слика од почетното мени

<img src=https://i.imgur.com/tn5SRN9.png></img>

Слика од играта

<img src=https://i.imgur.com/JnklZwQ.png></img>
