<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use SoftUniBlogBundle\Entity\Articlee;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

class HomeController extends Controller
{
    /**
     * @Route("/", name="blog_index")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function indexAction()
    {
        $articlees = $this-> getDoctrine()-> getRepository(Articlee::class)-> findAll();

        return $this->render("blog/index.html.twig", ["articlees"=> $articlees]);
    }
}
