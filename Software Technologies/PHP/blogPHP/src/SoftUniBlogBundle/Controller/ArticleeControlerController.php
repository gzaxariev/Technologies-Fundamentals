<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use SoftUniBlogBundle\Entity\Articlee;
use SoftUniBlogBundle\Form\ArticleeType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

use Symfony\Component\HttpFoundation\Request;

class ArticleeControlerController extends Controller
{
    /**
     * @param Request $request
     * @Route("/articlee/create", name="articlee_create")
     *
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {

        $articlee = new Articlee();
        $form = $this->createForm(ArticleeType::class, $articlee);

        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()){

            $articlee->setAuthor($this->getUser());
            $em = $this->getDoctrine()->getManager();
            $em-> persist($articlee);
            $em->flush();

            return $this->redirectToRoute("blog_index");
        }


        return $this->render("articlee/create.html.twig", ["form"=>$form->createView()]);

    }

    /**
     * @Route ("/articlee/{id}", name ="articlee_view")
     *
     * @param $id
     *
     *
     * @return \Symfony\Component\HttpFoundation\Response
     */
   public function viewArticlee($id){
       $articlee = $this-> getDoctrine()->getRepository(Articlee::class)->find($id);
       return $this->render('articlee/articlee.html.twig', ['articlee' => $articlee]);
   }


}
