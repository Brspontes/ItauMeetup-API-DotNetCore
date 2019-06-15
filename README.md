# ItauMetup-API-DotNetCore

### Metup Itaú Unibanco
![Image of Itau](https://res-4.cloudinary.com/crunchbase-production/image/upload/c_lpad,h_256,w_256,f_auto,q_auto:eco/v1454916654/izlscmevsdu9nxit3o2h.png)

## API

### GET
to get all entries use Get without parameters

### GET {Id}

{
	"Id" : "274c5475-7bb1-4c5c-aad2-8fcec841d64f"
}

### POST

{
	"FirstName" : "Peter",
	"LastName" : "Parker",
	"Description" : "Poderes de lançar teia!",
	"SuperHeroName" : "SpiderMan",
 	"ProfilePicture" : "teste.jpg"
}

### PUT
{
 	"Id": "274c5475-7bb1-4c5c-aad2-8fcec841d64f",
 	"FirstName" : "Steve",
 	"LastName" : "Rogers",
 	"Description" : "Um cara foda",
 	"SuperHeroName" : "Captain America",
 	"ProfilePicture" : "Captain.jpg"
}

### DELETE
{
	"Id" : "274c5475-7bb1-4c5c-aad2-8fcec841d64f"
}

## Connection String 
 ItauMetup-API-DotNetCore/src/Brspontes.Infra/MySQLContext/MySQLContexts.cs 

### Swagger Documentation
https://localhost:XXXX/swagger/index.html