<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssignmentWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <section id="main-slider" class="no-margin">
        <div class="carousel slide">
            <ol class="carousel-indicators">
                <li data-target="#main-slider" data-slide-to="0" class="active"></li>
                <li data-target="#main-slider" data-slide-to="1"></li>
                <li data-target="#main-slider" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">

                <div class="item active" style="background-image: url(images/slider/bg4.jpg)">
                    <div class="container">
                        <div class="row slide-margin">
                            <div class="col-sm-6">
                                <div class="carousel-content">
                                    <h1 class="animation animated-item-1">Since 1971, it always has been and will always be about quality. We’re passionate about ethically sourcing only the finest Arabica beans and roasting them with great care.</h1>
                                    <h2 class="animation animated-item-2">Our passion for coffee is rivaled only by our love of sharing it</h2>
                                    <a class="btn-slide animation animated-item-3" href="#">Read More</a>
                                </div>
                            </div>

                            <div class="col-sm-6 hidden-xs animation animated-item-4">
                                <div class="slider-img">
                                    <img src="images/slider/img1.png" class="img-responsive">
                                </div>
                            </div>

                        </div>
                    </div>
                </div><!--/.item-->
    <div class="item" style="background-image: url(images/slider/bg4.jpg)">
        <div class="container">
            <div class="row slide-margin">
                <div class="col-sm-6">
                    <div class="carousel-content">
                        <h1 class="animation animated-item-1">We Care About The Environment!</h1>
                        <h2 class="animation animated-item-2">We want our coffee to leave a lasting impression on you, not our environment. That's why we do everything we possibly can to use sustainable and recyclable products and equipment.</h2>
                        <a class="btn-slide animation animated-item-3" href="#">Read More</a>
                    </div>
                </div>

                <div class="col-sm-6 hidden-xs animation animated-item-4">
                    <div class="slider-img">
                        <img src="images/slider/img2.jpg" class="img-responsive">
                    </div>
                </div>

            </div>
        </div>
    </div>
    <!--/.item-->

    <div class="item" style="background-image: url(images/slider/bg4.jpg)">
        <div class="container">
            <div class="row slide-margin">
                <div class="col-sm-6">
                    <div class="carousel-content">
                        <h1 class="animation animated-item-1">Sustainable Support</h1>
                        <h2 class="animation animated-item-2">The only coffee chain in the UK that only uses sustainably grown beans sourced from Rainforest Alliance Certified farms.</h2>
                        <a class="btn-slide animation animated-item-3" href="#">Read More</a>
                    </div>
                </div>
                <div class="col-sm-6 hidden-xs animation animated-item-4">
                    <div class="slider-img">
                        <img src="images/slider/img3.jpg" class="img-responsive">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/.item-->
    </div><!--/.carousel-inner-->
    </div><!--/.carousel-->
    <a class="prev hidden-xs" href="#main-slider" data-slide="prev">
        <i class="fa fa-chevron-left"></i>
    </a>
    <a class="next hidden-xs" href="#main-slider" data-slide="next">
        <i class="fa fa-chevron-right"></i>
    </a>
    </section>
    <!--/#main-slider-->
    <section id="feature">
        <div class="container">
            <div class="center wow fadeInDown">
                <h2>Our Coffee</h2>
                <p class="lead">
                    Every day, you can help prevent deforestation, curb climate change, protect wildlife, alleviate poverty and transform business practices.
                        <br>
                    Having a sustainable milk supply allows us utmost traceability in the milk we supply to our stores and we are committed to supporting the British dairy industry and safeguarding future British milk supplies.
                </p>
            </div>

            <div class="row">
                <div class="features">
                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-th-list"></i>
                            <h2>Whole Bean</h2>
                            <h3>Whole bean coffee is the recommended state that coffee should be in when purchased to guarantee freshness.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-th"></i>
                            <h2>Instant</h2>
                            <h3> In the first, liquid coffee is sprayed in a fine mist through very hot, very dry air. By the time the coffee droplets land, they have dried into a powder.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-cloud-download"></i>
                            <h2>Environment</h2>
                            <h3>Taking responsibility for the environment is a vital part of the Katies Coffee code of ethics. We’re finding ethical ways to minimise our environmental footprint, tackle climate change, and inspire others to do the same.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-comment"></i>
                            <h2>Ethical Sourcing</h2>
                            <h3>We’re committed to buying and serving the highest-quality, responsibly grown, ethically traded coffee to help create a better future for farmers.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-cogs"></i>
                            <h2>Espresso</h2>
                            <h3>There is no plant that grows espresso beans or roasting style that makes espresso beans. The beans that are used to make espresso can be a blend of different coffees or one specific type of coffee bean.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->

                    <div class="col-md-4 col-sm-6 wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
                        <div class="feature-wrap">
                            <i class="fa fa-heart"></i>
                            <h2>Latte</h2>
                            <h3>Hold back the foam with a spoon, and pour the warm milk over the espresso.</h3>
                        </div>
                    </div>
                    <!--/.col-md-4-->
                </div>
                <!--/.services-->
            </div>
            <!--/.row-->
        </div>
        <!--/.container-->
    </section>
    <!--/#feature-->

   

    
    <section id="bottom">
        <div class="container wow fadeInDown" data-wow-duration="1000ms" data-wow-delay="600ms">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Company</h3>
                        <ul>
                            <li><a href="#">About us</a></li>
                            <li><a href="#">We are hiring</a></li>
                            <li><a href="#">Meet the team</a></li>
                            <li><a href="#">Copyright</a></li>
                            <li><a href="#">Terms of use</a></li>
                        </ul>
                    </div>
                </div>
                <!--/.col-md-3-->

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Support</h3>
                        <ul>
                            <li><a href="#">Faq</a></li>
                            <li><a href="#">Blog</a></li>
                            <li><a href="#">Forum</a></li>
                            <li><a href="#">Documentation</a></li>
                            <li><a href="#">Refund policy</a></li>
                        </ul>
                    </div>
                </div>
                <!--/.col-md-3-->

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Developers</h3>
                        <ul>
                            <li><a href="#">Billing system</a></li>
                            <li><a href="#">Privacy policy</a></li>
                            <li><a href="#">Contact us</a></li>
                            <li><a href="#">Our Heritage</a></li>
                            <li><a href="#">Retail Careers</a></li>
                        </ul>
                    </div>
                </div>
                <!--/.col-md-3-->

                <div class="col-md-3 col-sm-6">
                    <div class="widget">
                        <h3>Our Partners</h3>
                        <ul>
                            <li><a href="#">Adipisicing Elit</a></li>
                            <li><a href="#">Eiusmod</a></li>
                            <li><a href="#">Tempor</a></li>
                            <li><a href="#">Veniam</a></li>
                            <li><a href="#">Exercitation</a></li>
                        </ul>
                    </div>
                </div>
                <!--/.col-md-3-->
            </div>
        </div>
    </section>
    <!--/#bottom-->

</asp:Content>
