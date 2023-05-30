<?php
$servername = "localhost";
$username = "mysql";
$password = "";
$dbname = "cadastro";

// Cria a conexão com o banco de dados
$conn = new mysqli($127.0.0.1, $mysql, $password, $cadastro);

// Verifica a conexão
if ($conn->connect_error) {
    die("Falha na conexão: " . $conn->connect_error);
}

// Obtém os dados do formulário
$nome = $_POST['nome'];
$informacoesCadastrais = $_POST['informacoesCadastrais'];
$endereco = $_POST['endereco'];

// Insere os dados no banco de dados
$sql = "INSERT INTO cadastro (nome, informacoesCadastrais, endereco) VALUES ('$nome', '$informacoesCadastrais', '$endereco')";

if ($conn->query($sql) === TRUE) {
    echo "Dados inseridos com sucesso!";
} else {
    echo "Erro ao inserir dados: " . $conn->error;
}

// Fecha a conexão com o banco de dados
$conn->close();
?>