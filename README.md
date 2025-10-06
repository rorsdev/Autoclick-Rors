# Proyecto C# (Autoclick)

## Guía rápida / Apuntes

### 1. Preparar el entorno
- Instalar **.NET SDK** según tu sistema operativo.
- Configurar tu IDE o editor de código (Visual Studio, VS Code, Rider, etc.).

### 2. Crear un nuevo proyecto
```
dotnet new console --output .
```

> para winforms (ventanas) (Si se ha creado con el otro, debemos modificar el csproj")
<sub>dotnet new dotnet new winforms --output .</sub>

### 3- Para crear los binarios:
```dotnet build
```

### 4- Para ejecutar el programa
```
dotnet run
```

### 5- Modicamos program.cs para personalizar el static void Main(string args[])

### 6- Añadimos .cs para la ventana principal 
```
dotnet new class -n MainWindow -o . 
```
