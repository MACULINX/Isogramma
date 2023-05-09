# Isogramma

## Che cos'e' un isogramma

Un isogramma e' una frase composta da lettere che non si ripetono, sono ammessi segni di punteggiatura e spazi

Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca. 

Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.

Per esempio le cifre decimali possono essere mappate secondo questo schema:

P	A	T	H	F	I	N	D	E	R

1	2	3	4	5	6	7	8	9	0

Ammettiamo che il prezzo indicato fosse 1200 € ma nel cartellino ci fossero anche le lettere FRR, il venditore saprebbe che il prezzo originale era 500 € in modo da non scendere sotto quella soglia.


## Fine del programma

Determinare se una stringa e' un isogramma o meno.

## Descrizione del codice

```c#
public static bool Verifica(string word)
{
    word = word.ToLower();

    for (int i = 0; i < word.Length; i++)
        for (int j = i+1; j < word.Length; j++)
            if( (word[i] == word[j] ) && ( word[i] != ' ' ) && ( word[i] != '-' ))
                return false;

    return true;
}
```
Il codice parte portando in minuscolo tutte le lettere, successivamente entra dentro 2 cicli for per scorrere la stringa.
Questi due cicli puntano sempre due lettere diverse che vengono controllate da un if, quest'ultimo si accerta che le lettere putante siano diverse tra di loro e che non siano uno spazio o un carattere. Se durante questa ispezione si verifica una delle condizioni l'algoritmo torna direttamente il valore FALSE, altrimenti quando i 2 for finiranno il loro controllo tornera' TRUE. 