<!DOCTYPE html>
<html lang="en">
<head>
    <title>Cook yourself</title>
    <meta charset="utf-8">
    <link rel="icon" href="images/icone.jpg" type="image/x-icon" />
    <link rel="shortcut icon" href="images/icone.jpg" type="image/x-icon" />
    <link rel="stylesheet" href="css/reset.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen">
    <link rel="stylesheet" href="css/layout.css" type="text/css" media="screen">
    <link href='http://fonts.googleapis.com/css?family=Adamina' rel='stylesheet' type='text/css'>   
    <script src="js/jquery-1.6.3.min.js" type="text/javascript"></script>
    <script src="js/cufon-yui.js" type="text/javascript"></script>
    <script src="js/cufon-replace.js" type="text/javascript"></script>
    <script src="js/Lobster_13_400.font.js" type="text/javascript"></script>
    <script src="js/NewsGoth_BT_400.font.js" type="text/javascript"></script>
    <script src="js/FF-cash.js" type="text/javascript"></script>
    <script src="js/easyTooltip.js" type="text/javascript"></script>
	<script src="js/script.js" type="text/javascript"></script>
    <script src="js/bgSlider.js" type="text/javascript"></script>
</head>
<body id="page3">
	<div id="bgSlider"></div>
    <div class="bg_spinner"></div>
	<div class="extra">
        <!--==============================header=================================-->
        <header>
        	<div class="top-row">
            	<div class="main">
                	<div class="wrapper">
                        <h1><a href="index.php">GoodCook</a></h1>
                        </div>
                </div>
            </div>
            <div class="menu-row">
            	<div class="menu-border">
                	<div class="main">
                        <nav>
                            <ul class="menu">
                                <li><a class="inicio" href="index.php">Inicio</a></li>
                                <li><a href="sobre.php">Sobre</a></li>
                                <li><a class="salgados.php" href="salgados.php">Salgados</a></li>
                                <li><a href="doces.php">Doces</a></li>
                                <li><a href="lanches.php">Lanches</a></li>
                                <li><a href="bebidas.php">Bebidas</a></li>
                                <li class="last"><a href="contato.php">Contato</a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </header>
        
        <!--==============================content================================-->
        <div class="inner">
            <div class="main">
                <section id="content">
                    <div class="indent">
                    	<div class="wrapper">
                        	<article class="col-1">
                                
                                <div class="bg">
                                    <div class="padding">
                                        <h3 class="p2">Principais receitas salgadas</h3>
                                        <div class="salgadas">
                                            <div class="extra-wrap"> 
											<?php
													$servername = "localhost";
													$username = "alunos";
													$password = "etec";
													$dbname = "db_CookYourself";

													// Create connection
													$conn = new mysqli($servername, $username, $password, $dbname);
													// Check connection
													if ($conn->connect_error) {
														die("Connection failed: " . $conn->connect_error);
													}

													$sql = "SELECT receita_titulo, receita_custoTotal, receita_preparo, receita_ingrediente1,
													receita_ingrediente2,
													receita_ingrediente3,
													receita_ingrediente4,
													receita_ingrediente5,
													receita_ingrediente6,
													receita_ingrediente7,
													receita_ingrediente8,
													receita_ingrediente9,
													receita_ingrediente10
													FROM tbl_receita where receita_tipo = 'Salgado';";
													$result = $conn->query($sql);

													if ($result->num_rows > 0) {
														// output data of each row
														while($row = $result->fetch_assoc()) {
															?>
															<font style="font-size:200%;"color="orange">Receita</font>
															<font style="font-size:200%;"color="orange">
															<?php
															echo $row["receita_titulo"]; 
															"<br> " ;
															?>
															</font>
															<font style="font-size:100%;"color="blue">
															<?php
															echo "<br>";
															echo "Custo: " . $row["receita_custoTotal"];
															?>
															</font>
															<?php
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente1"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente2"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente3"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente4"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente5"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente6"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente7"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente8"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente9"];
															echo "<br>";
															echo "<br>";
															echo "⊳ ";
															echo $row["receita_ingrediente10"];
															echo "<br>";
															echo "<br>";
															echo $row["receita_preparo"]. "<br>";
														}
													} else {
														echo "0 results";
													}
													$conn->close();
													?>                                                                                                                            
                                    </div>
                                </div>
                        </div>
                    </div>
                </section>
                <div class="block"></div>
            </div>
        </div>
    </div>
	<!--==============================footer=================================-->
    <footer>
    	<div class="padding">
        	<div class="main">
                <div class="wrapper">
                	<div class="fleft footer-text">
                        <span>Cook yourself</span> &copy; 2016
                        <strong>Website programado por:<a>RSF Design e CIA</a> </strong>
                
            </div>
        </div>
    </footer>
    <script type="text/javascript"> Cufon.now(); </script>
</body>
</html>