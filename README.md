# FTBackend

Este projeto foi feito utilizando de .NET versão 6.0.
Feito em conjunto com o projeto [FTFrontend](https://github.com/Zem1991/FTFrontend).

Um simples aplicativo para a leitura, criação, atualização e exclusão de registros de empresas, produtos e compras.
Tanto o backend quanto o banco de dados estão contidos em um contâiner Docker. Já o frontend é feito em Angular, rodando no navegador.

Para executar pelo Docker, bastam os comandos:
`docker build . -t "ftbackend"`
`docker-compose up`

Ao executar este projeto pelo Docker, suas APIs estarão expostas pela URL: `http://localhost:8088/api/`.
