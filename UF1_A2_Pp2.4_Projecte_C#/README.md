Aquesta tasca és un projecte final de C# que té l'objectiu de crear un casino virtual implementant diversos jocs amb apostes i regles de cada joc per a l'experiècia de l'usuari.

Compleix aquestes característiques:

- Començar amb un saldo inicial de diners.

- Triar entre diversos jocs simples per apostar. (N’hi ha un munt, per exemple ruleta, black jack (o 7 ½ ), màquines escurabutxaques, carreres de cavalls simulades...)

- Jugar i veure si guanya o perd.

- Actualitzar el saldo després de cada partida.

- Sortir del casino en qualsevol moment amb un balanç final (si ja no disposem de més saldo ens ho ha d’informar i enviar-nos a la sortida també).

JOC 1: Ruleta --> El primer joc consisteix en que l'usuari ha d'apostar una quantitat de diners, després escollir a on vol apostar (número del 0-50 o color vermell-negre-verd), si l'encerta el jugador guanya el premi que és el doble del que ha apostat al principi.

JOC 2: Blackjack --> En aquest joc l'usuari ha d'apostar primer, genera una quantitat aleatòria entre 12 i 21 i entre 16 i 22. Pregunta a l'usuari si vol una carta més per poder arribar a 21. Si l'usuari arriba a 21 punts o el més aprop, guanya el doble del que va apostar, sinó la màquina guanya per tenir més punts. 

JOC 3: Carrera de cavalls --> En la carrera de cavalls s'aposta una quantita de diners, hi han 5 cavalls i un d'ells és el guanyador, i l'encerta guanya el doble del que va apostar, sino el perd.

JOC 4: Màquina escarabutxaques --> El jugador aposta diners, aquest ha de tocar qualsevol tecla i la màquina escaraburxaques començarà a girar i donarà 3 nombres aleatoris (taronjes, diamants... etc), si els 3 elements són els mateixos guanya el premi (el doble de l'apostat) i sino es resta del saldo.

JOC 5: Daus --> Per últim al joc dels daus, el jugador haurà d'apostar i llençar 2 daus, la suma dels números de cada dau ha de donar el mateix nombre que escullis. El número ha d'estar entre 2 - 12, la màquina genera el número des 2 das aleatòriament i després suma els números.

OPCIÓ 6: Sortir del casino amb els diners que s'ha quedat l'usuari.
