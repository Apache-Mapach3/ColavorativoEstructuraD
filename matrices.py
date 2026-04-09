matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]
def imprimir_matriz(m):
    for fila in m:
        for elemento in fila:
            print(elemento, end="\t")
        print()
print("Matriz original:")
imprimir_matriz(matriz)
#Recorrido por columnas #
print("\nRecorrido por columnas:")
filas = len(matriz)
columnas = len(matriz[0])
for j in range(columnas):
    for i in range(filas):
        print(matriz[i][j], end=" ")
    print()
#Suma#
suma = sum(sum(fila) for fila in matriz)
print(f"\nSuma total: {suma}")
#intercambio de filas#
matriz[0], matriz[-1] = matriz[-1], matriz[0]
print("\nMatriz despues de intercambiar filas:")
imprimir_matriz(matriz)