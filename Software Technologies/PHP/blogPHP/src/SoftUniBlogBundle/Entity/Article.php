<?php

namespace SoftUniBlogBundle\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * Article
 *
 * @ORM\Table(name="article")
 * @ORM\Entity(repositoryClass="SoftUniBlogBundle\Repository\ArticleRepository")
 */
class Article
{
    /**
     * @var int
     *
     * @ORM\Column(name="id", type="integer")
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="AUTO")
     */
    private $id;

    /**
     * @var string
     *
     * @ORM\Column(name="arop", type="string", length=255)
     */
    private $arop;


    /**
     * Get id
     *
     * @return int
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Set arop
     *
     * @param string $arop
     *
     * @return Article
     */
    public function setArop($arop)
    {
        $this->arop = $arop;

        return $this;
    }

    /**
     * Get arop
     *
     * @return string
     */
    public function getArop()
    {
        return $this->arop;
    }
}

