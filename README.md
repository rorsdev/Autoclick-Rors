Proyecto C# (autoclick)

Mis apuntes 

1- Instalar SDK, preparar entorno, etc

2- Crear nuevo proyecyo de c#
<script>dotnet new console --output .</script>

para winforms (ventanas) (Si se ha creado con el otro, debemos modificar el csproj")
<script>dotnet new dotnet new winforms --output .</script>

3- Para crear los binarios:
<script>dotnet build</script>

4- Para ejecutar el programa
<script>dotnet run</script>

4- Modicamos program.cs para personalizar el static void Main(string args[])

5- Para poder tener una venta instalamos paquete de windows.forms
<script>dotnet add package System.Windows.Forms</script>