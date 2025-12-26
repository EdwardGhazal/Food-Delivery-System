using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECTCSC323.NewFolder;

public class ADDRESS
{
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? ZipCode { get; set; }

    public ADDRESS() { }    
    public ADDRESS(string country, string city, string street, string zipCode)
    {
        Country = country;
        City = city;
        Street = street;
        ZipCode = zipCode;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {ZipCode}, {Country}";
    }
}