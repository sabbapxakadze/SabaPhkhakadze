using System.ComponentModel;
using System.Reflection;
using System.Text;

var assembly = Assembly.GetExecutingAssembly();

Type[] types = assembly.GetTypes();

Console.WriteLine("Right now we have this class\n");

foreach(Type type in types)
{
    if (!type.Name.Equals("Program"))
    {
        Console.WriteLine("Class: " + type.FullName + "\n");
    }
    else
    {
        continue;
    }
    var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

    int index = 0;

    foreach (var m in methods)
    {
        var parameters1 = m.GetParameters();
        var returnType1 = m.ReturnType;
        StringBuilder str = new StringBuilder();
        foreach (var p in parameters1)
        {
            str.Append(p.ParameterType.Name + " " + p.Name + " ");
        }
        if (str.Length == 0) str.Append("No parameter");
        Console.WriteLine($"{index}) Method name: {m.Name} \nParameters: {str.ToString()} \nReturn Type: {returnType1.Name} \n\n");
        index++;
    }
    Console.Write("Select a method by number: ");
    int methodNum = int.Parse(Console.ReadLine());

    while (methodNum > methods.Length - 1 || methodNum < 0)
    {
        Console.Write("You are not writing the correct method number. Please give a correct index: ");
        methodNum = int.Parse(Console.ReadLine());
    }


    var selectedMethod = methods[methodNum];
    Console.WriteLine($"You chose {selectedMethod.Name}");
    var parameters = selectedMethod.GetParameters();
    var returnType = methods[methodNum].ReturnType;

    object[] d = new object[parameters.Length];

    for (int i = 0; i < parameters.Length; i++)
    {
        Console.Write($"Enter value for parameter {parameters[i].Name} ({parameters[i].ParameterType.Name}): ");
        d[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("Output: " + selectedMethod.Invoke(null, d));
}