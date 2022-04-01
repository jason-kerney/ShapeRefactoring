<!--bl
(filemeta
    (title "How to Document"))
/bl-->

This project uses Book Lisp to generate documentation, which makes some things easier while adding a small amount of complexity. It is worth reading the [Book Lisp Documentation](https://github.com/cmstead/booklisp/blob/master/README.md).

### _Main.md is Everything

This project uses the ```_main.md``` file to control the flow of the resulting readme document. You can look at any main document to see how it is laid out or read the Book Lisp documentation.

### The Documentation Directory

The documentation directory is where the pieces of documentation that get compiled into the final readme sit. In this directory, you will find the ```_main.md``` and all other markdown documents that represent sections of the document.

This directory should reside at the same level as the gittey config file. Which should be the root directory for the exercise.