using System;

class Organization
{
    public string Name { get; set; }

    public Organization(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Организация: {Name}");
    }
}

class InsuranceCompany : Organization
{
    public string PolicyType { get; set; }

    public InsuranceCompany(string name, string policyType) : base(name)
    {
        PolicyType = policyType;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип страхования: {PolicyType}");
    }
}

class OilGasCompany : Organization
{
    public int OilProduction { get; set; }

    public OilGasCompany(string name, int oilProduction) : base(name)
    {
        OilProduction = oilProduction;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Добыча нефти: {OilProduction} баррелей в день");
    }
}

class Factory : Organization
{
    public string ProductType { get; set; }

    public Factory(string name, string productType) : base(name)
    {
        ProductType = productType;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип продукции: {ProductType}");
    }
}

class Program
{
    static void Main()
    {
        Organization org = new Organization("Компания XYZ");
        InsuranceCompany ins = new InsuranceCompany("Страховая компания ABC", "Автострахование");
        OilGasCompany oil = new OilGasCompany("Нефтегазовая компания OilCorp", 50000);
        Factory factory = new Factory("Завод MachineWorks", "Металлоконструкции");

        org.DisplayInfo();
        Console.WriteLine();
        ins.DisplayInfo();
        Console.WriteLine();
        oil.DisplayInfo();
        Console.WriteLine();
        factory.DisplayInfo();
    }
}
