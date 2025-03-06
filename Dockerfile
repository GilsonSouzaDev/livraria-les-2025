# Usar a imagem oficial do MySQL como base
FROM mysql:8.0

# Definir variáveis de ambiente para o MySQL
ENV MYSQL_ROOT_PASSWORD=rootpassword
ENV MYSQL_DATABASE=db_livraria
ENV MYSQL_USER=myuser
ENV MYSQL_PASSWORD=mypassword

# Copiar scripts SQL para serem executados na inicialização
COPY ./scripts/ /docker-entrypoint-initdb.d/

# Expor a porta padrão do MySQL
EXPOSE 3306