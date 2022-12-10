# ControleIaasAPI
## Funcionalidade
Essa API tem como funcionalidade controlar tantos os ativos, quanto os clientes e instâncias de DBs dos clientes que estão em IAAS.

## Motivações do Projeto
A ideia deste projeto originou-se a partir do momento em que foi necessário ter a gestão da informação do Hardware das máquinas, qual cliente estava alocado em qual máquina e quais recursos os clientes utilizavam, tais como, instâncias do SQL Server.

## Tecnologias Utilizadas
**AutoMapper** - Realiza o mapeamento dos Dtos para as Entities<br>
**Microsoft.EntityFrameWorkCore** - ORM (Mapeador relacionar objeto) utilizado para trabalhar com o banco de dados utilizando objetos <br>
**Microsoft.EntityFrameworkCore.Proxies** - Ferramenta do EntityFramework para realizar o lazy loading dos objetos <br>
**Microsoft.ENtity.FrameWorkCore.SqlServer** - Ferramenta do EntityFramework para trabalhar utilizando o SqlServer <br>
**Microsoft.Entity.FrameWorkCore.Tool** - Algumas ferramentas complementares do EntityFramework<br>
**Swashbuckle.AspNetCore** - Swagger para documentar as rotas da API <br>
**SQL Server** - Banco de dados para persistir os dados movimentados na API <br>

## Documentação das rotas
