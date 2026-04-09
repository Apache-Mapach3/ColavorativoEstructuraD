import random
#declaración e inicializacion#
arreglo = [random.randint(1, 100) for _ in range(10)]
print("Arreglo original:")
print(arreglo)
#recorrido con indice#
print("\nFor clásico (por indice):")
for i in range(len(arreglo)):
    print(arreglo[i], end=" ")
print()
#recorrido tipo foreach#
print("\nFor-each:")
for num in arreglo:
    print(num, end=" ")
print()
#busqueda sin modificar#
objetivo = int(input("\nIngrese valor a buscar: "))
encontrado = False
for i in range(len(arreglo)):
    if arreglo[i] == objetivo:
        print(f"Valor {objetivo} encontrado en el indice {i}")
        encontrado = True
        break
if not encontrado:
    print(f"Valor {objetivo} no encontrado")
#modifica impares a 0#
for i in range(len(arreglo)):
    if arreglo[i] % 2 != 0:
        arreglo[i] = 0
print("\nDespues de cambiar impares por 0:")
print(arreglo)
#multiplica por indice#
for i in range(len(arreglo)):
    arreglo[i] *= i
print("\nDespues de multiplicar por indice:")
print(arreglo)