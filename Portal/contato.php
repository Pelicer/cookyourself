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
<body id="page6">
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
                                <li><a href="salgados.php">Salgados</a></li>
                                <li><a href="doces.php">Doces</a></li>
                                <li><a href="lanches.php">Lanches</a></li>
                                <li><a href="bebidas.php">Bebidas</a></li>
                                <li class="conato"><a class="contato" href="contato.php">Contato</a></li>
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
                            	<div class="indent-left">
                                	<h3>Entre em contato:</h3>
                                    <div class="p3">
                                        <form action="enviado.php" id="contact-form" method="post" enctype="multipart/form-data">                    
                                            <fieldset>
											
                                                <label>
												<span class="text-form">Nome completo:</span><input name="nome" type="text"/>
												</label>                                           
												
												<label>
												<span class="text-form">E-mail:</span><input name="email" type="text"/>
												</label>                              
                                                
												<div class="wrapper">
                                                    <div class="text-form" >Mensagem:</div>
                                                    <div class="extra-wrap">
                                                        <textarea name="mensagem"></textarea>
                                                        <div class="clear"></div>
                                                        <div class="buttons">
                                                            <a class="button-2" href="#" onClick="document.getElementById('contact-form').submit()">Cancelar</a>
															    <input type="submit" value="Submit">
                                                        </div> 
                                                    </div>
                                                  </div>                            
                                            </fieldset>						
                                        </form>
                                    </div>
                                </div>
                            </article>
                            <article class="col-2">
                            	<h3 class="border-bot indent-bot">Outros contatos</h3>
                                <div class="img-indent-bot">
                                    <h6>Foco Fit</h6>
                                    <dl>
                                        <dd><span>Telefone:</span> +55(19) 99178-2234</dd>
                                    </dl>
                                </div>
                                <div class="img-indent-bot">
                                    <h6>Restaurante do Carlão</h6>
                                    <dl>
                                        <dd><span>Telefone:</span> +55 (19) 3819-6121</dd>
                                        <dd><span>Endereço:</span> Av Santana,1071 JD Amanda I</a></dd>
                                    </dl>
                                </div>
                                <div class="img-indent-bot">
                                    <h6>Empório Bolos</h6>
                                    <dl>
                                        <dd><span>Telefone:</span>  +55 (19) 3865-2620 </dd>
                                        <dd><span>Endereço:</span> Rua José Camilo de camargo,240 (Centro)</a></dd>
                                    </dl>
                                </div>
                                <h6>Pizzaria Brasil</h6>
                                <dl>
                                    <dd><span>Telefone:</span> +55 (19) 3887-2209</dd>
                                    <dd><span>Endereço:</span> Rua pico da bandeira,241 JD evereste </a></dd>
                                </dl>
                            </article>
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
                    <div class="fleft footer-text">
                        <span>Cook yourself</span> &copy; 2016
                        <strong>Website programado por:<a>RSF Design e CIA</a> </strong>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <script type="text/javascript"> Cufon.now(); </script>
</body>
</html>