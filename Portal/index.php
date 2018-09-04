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
    <script src="js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="js/tms-0.3.js" type="text/javascript"></script>
    <script src="js/tms_presets.js" type="text/javascript"></script>
</head>
<body id="page1">
        <!--==============================header=================================-->
        <header>
        	<div class="top-row">
            	<div class="main">
                	<div class="wrapper">
                        <h1><a href="index.php">Cook yourself</a></h1>
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
                    <div class="slider">
                        <ul class="items">
                            <li>
                                <img src="images/slider-img1.jpg" alt="" />
                                <div class="banner">
                                    <strong class="title">
                                        <strong>Voce sabia?</strong><em></em>
                                    </strong>
                                    <p class="p3">As abóboras surgiu a 9 mil anos, E por certo as folhas da planta também são comestível .</p>
                                </div>
                            </li>
                            <li>
                                <img src="images/slider-img2.jpg" alt="" />
                                <div class="banner">
                                    <strong class="title">
                                        <strong>Voce sabia?</strong><em></em>
                                    </strong>
                                    <p class="p3">A água de coco também pode ser usada como plasma sanguíneo, em casos de emergencia.</p>
                                </div>
                            </li>
                            <li>
                                <img src="images/slider-img3.jpg" alt="" />
                                <div class="banner">    
                                    <strong class="title">
                                        <strong>Voce sabia?</strong><em></em>
                                    </strong>
                                    <p class="p3">Quer ter uma alimentação saudável e mais qualidade de vida? Conheça os produtos foco fit, mais Informaçóes na pagina contatos.</p>
                                   </div>
                            </li>
                        </ul>
                        <a class="banner-2" href="#"></a>
                    </div>
                    <ul class="pags">
                        <li><a href="#">1</a></li>
                        <li><a href="#">2</a></li>
                        <li><a href="#">3</a></li>
                    </ul>
                    <div class="bg">
                        <div class="padding">
                            <div class="wrapper">
                                <article class="col-1">
                                    <h3>Objetivo do site</h3>
                                    <p>Nosso site tem como objetivo lhes apresentar receitas simples que não necessitam muito tempo nem muito esforço, para aqueles dias que você precisa mas não quer cozinhar!</p>
                                    <div class="relative">                                   
                            </div>
                                </article>
                                <article class="col-1">
                                    <h3>Por que temos esse objetivo?</h3>
                                    <p>Tenho 17 anos, e meus pais me deixaram em casa por um tempo sozinho, e eu ja estava cansado de cozinhar todo dia, entao resolvi procurar receitas simples para fazer, mas a coisa mais dificil na internet é encontrar coisas simples, principalmente quando você precisa...</p>
                                    <div class="relative">
                                    </div>
                                </article>
                                <article class="col-2">
                                    <h3></h3>
                                    <p></p>
                                    <div class="relative">
                                    </div>
                                </article>
                            </div>
                        </div>
                    </div>
                    <div class="padding-2">
                        <div class="indent-top">
                            <div class="wrapper">
                                <div class="extra-wrap">
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
                        <strong>Website programado por: <a>RSF Design e CIA</a></strong>
                        <!-- {%FOOTER_LINK} -->
                    
                </div>
            </div>
        </div>
    </footer>
    <script type="text/javascript"> Cufon.now(); </script>
    <script type="text/javascript">
		$(window).load(function() {
			$('.slider')._TMS({
				duration:1000,
				easing:'easeOutQuart',
				preset:'simpleFade',
				slideshow:10000,
				banners:'fade',
				pauseOnHover:true,
				waitBannerAnimation:false,
				pagination:'.pags'
			});
		});
    </script>
</body>
</html>
