/*  
###
//CADASTRAR
POST https://localhost:5001/odonto/paciente/create
Content-Type: application/json
{
    "Nome" : "bolacha",
    "Preco" : 4.5
}

###
//LISTAR
GET  https://localhost:5001/odonto/paciente/list
Content-Type: application/json

###
//EXCLUIR
POST https://localhost:5001/odonto/paciente/delete 
Content-Type: application/json
{
    "Id" : 1 
}

###
//ALTERAR
POST https://localhost:5001/odonto/paciente/update
Content-Type: application/json
{
    "Id" : 3, 
    "Nome" : "Caio",
    "Descricao" : "Have fun, Dont die"
}*/