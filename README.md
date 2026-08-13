COMO EJECUTAR EL PROGRAMA
1-El programa se ocupa en c# en el apartado de windown form App con las cuilidades de c# + windown + Desktop
2-Abrir el archivo "Desafio1"
3-Abrir el formulario Form1.
4-Ejecutar el programa con el boton de iniciar
5-El programa estara enseñando 2 textbox vacio y 1 ComboBox e un boton para interactuar "calcular"
6-Hacer lo siguiente 
Ingresar el precio original.
Ingresar el monto total de la compra.
Seleccionar una categoría.
Presionar Calcular.
7-El programa enseñara el precio final y si cumple alguna condicion del "switch" , se aplicara el descuento en la categoria correspondiente 
CARACTERISTICAS IMPLEMENTADAS 
1-Se a hecho un codigo base en windown form App
2-Se a aplicado los siguientes objetos al windown form app : 7 labeltext , 2 TextBox, 1 ComboBox , 1 button .
3-Se a aplicado 3 variables las cuales son : 
double precioOriginal;
double montoTotal;
double descuento = 0; (este para que el valor sea 0)
4-Sea creado 1 ComboBox con las siguiente categorias/opciones:
Electrónica
Ropa
Alimentos
Hogar
5-Se creo las 2 codigo de "requisito de logica" 
Uso de if-else para comprobar si el monto total cumple la condición necesaria para aplicar el descuento.
Uso de switch-case para determinar el porcentaje de descuento según la categoría.
5-Se Creo un boton con la finalidad de : Cálculo del precio final después de aplicar el descuento.
6-Se hizo un label para visualizar del precio final 
7-Visualización de un mensaje indicando si se aplicó un descuento y cuál fue el porcentaje.
SE HIZO LO SIGUIENTE CON LOS DESCUENTOS :
Descuentos por Categoría:
o Electrónica: 10% de descuento si el monto total de la compra es mayor a $500.
o Ropa: 15% de descuento si el monto total de la compra es mayor a $300.
o Alimentos: 5% de descuento si el monto total de la compra es mayor a $200.
o Hogar: 20% de descuento si el monto total de la compra es mayor a $400.
Si el monto no cumple con los requisitos en cada categoria , no se aplica descuento
8-El if Else capta el monto total para ver si cumple el requisito de aplicar el descuento , de lo contrario no se aplica , SI APLICA ,pasa el caso de switch
9-El Switch se parece mucho al if else de cumplir una condicion , pero este ya tiene la condiciones ya establecida / configurada , e aplicara el descuento a cada 
categoria correspondiente.
