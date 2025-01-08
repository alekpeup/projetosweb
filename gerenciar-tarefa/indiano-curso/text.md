to all get all documents properties
<script>
  function f1(){
      for(var property in document){
        document.write(property + "<br>")
      }
  }
  f1();
</script>


events are related to browser not related to document.

- Difference between Properties and Methods
-- Properties contains the data 
-- Methods contains the logic



DOM Manipulation

-Access and use HTML elements. (done)
-Configure and Modify their data and style.
-Removing Elements

-in modern programming we use selector to access HTML elements. As it can use CSS Selectors.




Creating and placing new nodes:
appendChild used to add an element into the parent element






- create element by using "document.createElement()"
- Add element as child by using "appendChild()".


-- Creating element by using its Base Class
ex:

<!DOCTYPE html>
<html>
  <head>
    <script>
      function bodyload()
      {
        var sect = document.querySelector("section");
        var par = document.createElement("p");
        par.textContent = "Hello! Welcome to Heaven";
        sect.appendChild(par);
        
        var fig = document.querySelector("figure");
        var pic = new Image();
        pic.width = "500";
        pic.height = "200";
        pic.border = "1";
        pic.src = "https://www.shutterstock.com/shutterstock/photos/1032541603/display_1500/stock-photo-the-young-and-conceptual-image-of-a-large-stone-in-the-shape-of-the-human-brain-1032541603.jpg";
        fig.appendChild(pic)
      }
    </script>
  </head>
  <body onload="bodyload()">
    <figure>
          
    </figure>
    
      <section>
       
      </section>
  </body>
</html>