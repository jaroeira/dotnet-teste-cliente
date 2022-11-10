# Demo Project

This demo project was created using the .NET 6 ASP.NET Core with C#. It is a simple api where every endpoint expects an object "Clientes" containing an array of customers with id, name, cpf number and salary.

## Endpoints

- POST /api/customer return a list of customers sorted by name
- POST /api/customer/:id find and return a customer by id
- POST /api/customer/salary?cpf=###.###.###-##&percentage=## return a % of the customer salary. default = 30

## Test Data

{
    "clientes": [
        {
                      "id":"1",
            "nome":"Maria Sousa", 
            "cpf":"258.851.854-74", 
            "salario":"2500.77"
        },
        {
            "id":"2",
            "nome":"Jose Santos", 
            "cpf":"358.800.700-01", 
            "salario":"1851.88"
        }, 
        {
            "id":"4",
            "nome":"Amanda Gasper Libero", 
            "cpf":"258.587.854-55", 
            "salario":"8755.00"
        },
        {
            "id":"5",
            "nome":"Thais Alcantara Machado", 
            "cpf":"211.855.854-99", 
            "salario":"1250.01"
        }
    ]
}


## 🔧 Runing the project

### Using Docker and VSCode to run the project in a remote container:

- Clone the repo on your local machine
- Make sure you have Docker installed on your local machine
- Make sure you have VSCode with the Remote Container extension installed
- Navigate on your command line interface to the root folder of the project
- Enter the command: code .
- VSCode will ask with you want to open it in a remote container. Click yes;
- Waint until the container is ready
- On VSCode terminal navigate to the API folder and enter the command: dotnet run;
- The api responds on https://localhost:7284 and http://localhost:5008
- To access the swagger documentation: https://localhost:7284/swagger


<p align="center">Copyright © 2022 João Aroeira</p>