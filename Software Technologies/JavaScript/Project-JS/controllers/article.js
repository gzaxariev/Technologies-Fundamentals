const Article = require('../models').Article;
const User = require('../models').User;
module.exports = {
   createGet: (req, res) => {
       res.render('article/create')
   },

    createPost: (req, res) => {

      const title = req.body.title;
      const content = req.body.content;

      let errorMsg = false;

      if (!req.isAuthenticated()){
         errorMsg ='You must be logged in before creating articles';
      }
      else if (!title) {
          errorMsg = 'Title cannot be empty';

      }
      else if (!content) {
         errorMsg = 'Content cannot be empty'

      }
      if (errorMsg){
          res.render('article/create', {error: errorMsg,title,content});
          return;
      }


      const  authorId = req.user.id;

      const article = {
          title,
          content,
          authorId
      };

      Article.create(article).then(article => {
         res.redirect('/');
      }).catch(e => {
         console.log(e.message);
         res.render('article/create');
      });

    },
    details: (req, res) => {

      const articleId = Number(req.params.id);

      Article.findById(articleId,{
          include:[{
             model: User
          }]
        }).then(article => {
           if (article === null) {
              throw new  Error('Article not found' + articleId)
           }

         res.render('article/details', article.dataValues)

      }).catch(e => {
         console.log(e.message);
          res.redirect('/404');
      });

    }
};