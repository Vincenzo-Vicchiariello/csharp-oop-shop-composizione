// See https://aka.ms/new-console-template for more information
using Shop;
using System.Net.Http.Headers;


Negozio mioNegozio = new Negozio("nome","indirizzo", "citta", 104);

mioNegozio.setIndirizzoNegozio("Bowser");

Console.WriteLine(mioNegozio.getIndirizzo());


mioNegozio.setIndirizzoNegozio("Via Roma");

Console.WriteLine(mioNegozio.getIndirizzo());


mioNegozio.setCittaNegozio("Napoli");

Console.WriteLine(mioNegozio.getCitta());


mioNegozio.setCivico(21);

Console.WriteLine(mioNegozio.getCivico());

