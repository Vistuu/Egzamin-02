import math

def sito_eratostenesa(tablica, n):
    """
    Funkcja realizuje algorytm Sita Eratostenesa.
    Argumenty:
    - tablica: lista typu boolean, gdzie wartość True oznacza, że indeks jest potencjalnie liczbą pierwszą.
    - n: górna granica przedziału liczb naturalnych, w którym wyszukujemy liczby pierwsze.
    """
    for i in range(2, int(math.sqrt(n)) + 1):  
        if tablica[i]:  
            for j in range(i * 2, n + 1, i):  
                tablica[j] = False

def znajdz_liczby_pierwsze(n):
    """
    Funkcja wyszukuje liczby pierwsze w przedziale od 2 do n.
    Argumenty:
    - n: górna granica przedziału, w którym wyszukujemy liczby pierwsze.
    Zwraca:
    - lista liczb pierwszych w przedziale [2, n].
    """

    tablica = [True] * (n + 1)
    

    sito_eratostenesa(tablica, n)
    

    liczby_pierwsze = [i for i in range(2, n + 1) if tablica[i]]
    return liczby_pierwsze

def main():
    """
    Główna funkcja programu, wyświetlająca liczby pierwsze w przedziale 2..100.
    """
    n = 100
    liczby_pierwsze = znajdz_liczby_pierwsze(n)
    

    print("Liczby pierwsze w przedziale od 2 do", n, "to:")
    print(", ".join(map(str, liczby_pierwsze)))  

if __name__ == "__main__":
    main()



