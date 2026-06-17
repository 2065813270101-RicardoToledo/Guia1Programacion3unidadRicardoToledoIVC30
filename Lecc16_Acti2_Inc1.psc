Algoritmo Lecc16_Acti2_Inc1
    
    Escribir "DATOS ACADÉMICOS"
    Escribir "Nombre: Ricardo Toledo"
    Escribir "Grado: IVC"
    Escribir "Clave: 30"
    Escribir "" 
    
    
    Definir edadPersonas, cantidadPersonasMayores, cantidadPersonasMenores, i Como Entero
    Dimension edadPersonas[7]
    
    cantidadPersonasMayores <- 0
    cantidadPersonasMenores <- 0
    
    
    Para i <- 1 Hasta 7 Con Paso 1 Hacer
        Escribir Sin Saltar "Ingrese la edad de la persona ", i, ": "
        Leer edadPersonas[i]
        
        Si edadPersonas[i] >= 18 Entonces
            cantidadPersonasMayores <- cantidadPersonasMayores + 1
        SiNo
            cantidadPersonasMenores <- cantidadPersonasMenores + 1
        FinSi
    FinPara
    
    Escribir ""
    Escribir "Cantidad de personas mayores de edad: ", cantidadPersonasMayores
    Escribir ""
    Escribir "Cantidad de personas menores de edad: ", cantidadPersonasMenores
    Escribir "Total de Personas: 7"
    
FinAlgoritmo
