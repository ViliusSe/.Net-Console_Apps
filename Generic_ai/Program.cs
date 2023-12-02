//Generic neturi specifinnio tipo.
//skirta atsikri logika nuo duomenu tipo.

//List yra generikas, i ji gaima ideti bet ka(nevisai).

using Generic_ai;

void ShowItem<T>(T item)
{
    Console.WriteLine(item);
}

Validation<string> validacija = new Validation<string>();

validacija.ValidateObj<string>(null);

Validation<string>.Validate<string>("5");

Validation<int>.Validate<int>(0);

