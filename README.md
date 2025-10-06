# Proyecto C# (Autoclick)

## Guía rápida / Apuntes

### 1. Preparar el entorno
- Instalar **.NET SDK** según tu sistema operativo.
- Configurar tu IDE o editor de código (Visual Studio, VS Code, Rider, etc.).

### 2. Crear un nuevo proyecto
```
dotnet new console --output .
```

> [!WARNING]
> para winforms (ventanas) (Si se ha creado con el otro, debemos modificar el csproj")
```
dotnet new dotnet new winforms --output .
```

### 3- Para crear los binarios:
```
dotnet build
```

### 4- Para ejecutar el programa
```
dotnet run
```

### 5- Modificamos Program.cs para personalizar el código 
```
class Program
{
  static void Main(string[] args)
  {
    ...
  }
}
```

### 6- Añadimos .cs para la ventana principal 
```
dotnet new class -n MainWindow -o . 
```

https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.414-windows-x64-installer


### 7- Se recomienda meter la lógica de detras la 'Window' en un servicio