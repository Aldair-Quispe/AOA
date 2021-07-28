@Code
    ViewData("Title") = "About"
End Code

    <!-- Favicon -->
    <link href="estilos/img/favicon.ico" rel="icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400|Source+Code+Pro:700,900&display=swap" rel="stylesheet">

    <!-- CSS Libraries -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css" rel="stylesheet">
    <link href="estilos/lib/slick/slick.css" rel="stylesheet">
    <link href="estilos/lib/slick/slick-theme.css" rel="stylesheet">

    <!-- Template Stylesheet -->
    <link href="estilos/css/style.css" rel="stylesheet">

<Style>
    .ropa{
        width: 40%;
    }
</Style>

<!-- Nav Bar End -->
<!-- Bottom Bar Start -->
<br>
<div class="bottom-bar">
    <div class="container-fluid">
        <div class="row align-items-center">
            
            <div class="col-md-3">
                <div class="user">
                    <a href="wishlist.html" class="btn wishlist">
                        <i class="fa fa-heart"></i>
                        <span>(0)</span>
                    </a>
                    <a href="cart.html" class="btn cart">
                        <i class="fa fa-shopping-cart"></i>
                        <span>(0)</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Compras -->
<h2>Tus compras actuales son:</h2>

<div class="wishlist-page">
    <div class="container-fluid">
        <div class="wishlist-page-inner">
            <div class="row">
                <div class="col-md-12">
                    <div class="table-responsive">
                        <table class="table table-bordered">
                            <thead class="thead-dark">
                                <tr>
                                    <th>Producto</th>
                                    <th>Precio</th>
                                    <th>Quantity</th>
                                    <th>Comprar</th>
                                    <th>Eliminar</th>
                                </tr>
                            </thead>
                            <tbody class="align-middle">
                                <tr>
                                    <td>
                                        <div class="img" style="text-align:center;">
                                            <a href="#"><img class="ropa" src="../../estilos/img/product-6.jpg" alt="Image"></a>
                                         
                                        </div>
                                    </td>
                                    <td>$99</td>
                                    <td>
                                        <div class="qty">
                                            <button class="btn-minus"><i class="fa fa-minus"></i></button>
                                            <input type="text" value="1">
                                            <button class="btn-plus"><i class="fa fa-plus"></i></button>
                                        </div>
                                    </td>
                                    <td><button class="btn-cart">Comprar</button></td>
                                    <td><button><i class="fa fa-trash"></i></button></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="img" style="text-align:center;">
                                            <a href="#"><img class="ropa" src="../../estilos/img/product-7.jpg" alt="Image"></a>
                                           
                                        </div>
                                    </td>
                                    <td>$99</td>
                                    <td>
                                        <div class="qty">
                                            <button class="btn-minus"><i class="fa fa-minus"></i></button>
                                            <input type="text" value="1">
                                            <button class="btn-plus"><i class="fa fa-plus"></i></button>
                                        </div>
                                    </td>
                                    <td><button class="btn-cart">Comprar</button></td>
                                    <td><button><i class="fa fa-trash"></i></button></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="img" style="text-align:center;">
                                            <a href="#"><img class="ropa" src="../../estilos/img/product-8.jpg" alt="Image"></a>
                                            
                                        </div>
                                    </td>
                                    <td>$99</td>
                                    <td>
                                        <div class="qty">
                                            <button class="btn-minus"><i class="fa fa-minus"></i></button>
                                            <input type="text" value="1">
                                            <button class="btn-plus"><i class="fa fa-plus"></i></button>
                                        </div>
                                    </td>
                                    <td><button class="btn-cart">Comprar</button></td>
                                    <td><button><i class="fa fa-trash"></i></button></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="img" style="text-align:center;">
                                            <a href="#"><img class="ropa" src="../../estilos/img/product-9.jpg" alt="Image"></a>
                                           
                                        </div>
                                    </td>
                                    <td>$99</td>
                                    <td>
                                        <div class="qty">
                                            <button class="btn-minus"><i class="fa fa-minus"></i></button>
                                            <input type="text" value="1">
                                            <button class="btn-plus"><i class="fa fa-plus"></i></button>
                                        </div>
                                    </td>
                                    <td><button class="btn-cart">Comprar</button></td>
                                    <td><button><i class="fa fa-trash"></i></button></td>
                                </tr>
                                <tr>
                                    <td>
                                        <div class="img" style="text-align:center;">
                                            <a href="#"><img class="ropa" src="../../estilos/img/product-10.jpg" alt="Image"></a>
                                            
                                        </div>
                                    </td>
                                    <td>$99</td>
                                    <td>
                                        <div class="qty">
                                            <button class="btn-minus"><i class="fa fa-minus"></i></button>
                                            <input type="text" value="1">
                                            <button class="btn-plus"><i class="fa fa-plus"></i></button>
                                        </div>
                                    </td>
                                    <td><button class="btn-cart">Comprar</button></td>
                                    <td><button><i class="fa fa-trash"></i></button></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Wishlist End -->
<!-- Footer Start -->
<div class="footer">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-3 col-md-6">
                <div class="footer-widget">
                    <h2>Visitanos</h2>
                    <div class="contact-info">
                        <p><i class="fa fa-map-marker"></i>123 Sinaloa, Bolivia</p>
                        <p><i class="fa fa-envelope"></i>atencion@AOA.com</p>
                        <p><i class="fa fa-phone"></i>+591-456-7890</p>
                    </div>
                </div>
            </div>

            <div class="col-lg-3 col-md-6">
                <div class="footer-widget">
                    <h2>Siguenos</h2>
                    <div class="contact-info">
                        <div class="social">
                            <a href=""><i class="fab fa-twitter"></i></a>
                            <a href=""><i class="fab fa-facebook-f"></i></a>
                            <a href=""><i class="fab fa-linkedin-in"></i></a>
                            <a href=""><i class="fab fa-instagram"></i></a>
                            <a href=""><i class="fab fa-youtube"></i></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-lg-3 col-md-6">
                <div class="footer-widget">
                    <h2>Sobre nosotros</h2>
                    <ul>
                        <li><a href="#">Nosotros</a></li>
                        <li><a href="#">Política de privacidad</a></li>
                        <li><a href="#">Términos y condiciones</a></li>
                    </ul>
                </div>
            </div>

            <div class="col-lg-3 col-md-6">
                <div class="footer-widget">
                    <h2>Q&A</h2>
                    <ul>
                        <li><a href="#">Política de pago</a></li>
                        <li><a href="#">Política de envío</a></li>
                        <li><a href="#">Política de devoluciones</a></li>
                    </ul>
                </div>
            </div>
        </div>


    </div>
</div>

<!-- Footer Bottom End -->
<!-- Back to Top -->
<a href="#" class="back-to-top"><i class="fa fa-chevron-up"></i></a>

<!-- JavaScript Libraries -->
<script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js"></script>
<script src="estilos/lib/easing/easing.min.js"></script>
<script src="estilos/lib/slick/slick.min.js"></script>

<!-- Template Javascript -->
<script src="estilos/js/main.js"></script>

