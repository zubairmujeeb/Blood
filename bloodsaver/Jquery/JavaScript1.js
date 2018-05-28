
       $(document).ready(function () {
           
           
           $('#Gender').change(function () {
               
               var m = $('#Gender option:selected').text();
               $('#v').html(m);
               if (m == "Select Gender") {
                   $('#gen').html("").addClass("");
                   $('input[type="submit"]').attr('disabled', true).css({
                       'border': '3px solid red'
                   });
                   $('#Gender').css({
                       'border': '3px solid green'
                   });


               }
               else {



                   $('#gen').html("").removeClass("colourchangingofname");
                   $('input[type="submit"]').attr('disabled', false).css({
                       'border': '3px solid green'
                   });

               }


           })


           $('input[type="submit"]').click(function () {
               var mx = $('#Gender option:selected').text();
               $('#v').html(m);
               if (m == "Select Gender")
               {
                   $('#gen').html("Please select Your Gender").addClass("colourchangingofname");
                   $('input[type="submit"]').attr('disabled', true).css({
                       'border': '3px solid red'
                   });
                   $("#Gender").css({
                       'border': '3px solid red'
                   })

                    
               }
               else 
               {
                  


                   $('#gen').html("").removeClass("colourchangingofname");
                   $('input[type="submit"]').attr('disabled', false);
                   $("#Gender").css({
                       'border': '3px solid green'
                   });

               }
           })
           
           $('#cnic').change(function () {

                
               cniccheck();


           })
           $("#email").change(function () {
             
                emailcheck();
           })
           $("#password").change(function () {
          
               paswordcheck();
           })


           function cniccheck() {


               var patren = new RegExp('^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$');
               if (patren.test($('#cnic').val())) {
                   $('#cniccheck').html("").removeClass("colourchangingofname");
                   $("#cnic").css({
                       'border': '3px solid green'
                   })
                   $('input[type="submit"]').attr('disabled', false);

               }
               else {
                   $('#cniccheck').html("Please correct e.g 35202-6455636-2").addClass("colourchangingofname");
                   $("#cnic").css({
                       'border':'3px solid red'
                   })
                   $('input[type="submit"]').attr('disabled', true);


               }
           }
            
           function emailcheck() {


               var patren = new RegExp('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$');
               if (patren.test($('#email').val())) {
                   $('#emailspan').html("<img src=images/tick.png alt=zubair height=15 width=15 />").removeClass("colourchangingofname");
                   $("#email").css({
                       'border': '3px solid green'
                   })
                   $('input[type="submit"]').attr('disabled', false);

               }
               else {
                   $('#emailspan').html("Please enter your correct Email e.g bobe12@@gamil.com").addClass("colourchangingofname");
                   $("#email").css({
                       'border': '3px solid red'
                   })
                   $('input[type="submit"]').attr('disabled', true);


               }
           }

           function paswordcheck() {


               var patren = new RegExp('^(?=.*[A-Z].*[A-Z])(?=.*[!@@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$');
               if (patren.test($('#password').val())) {
                   $('#paswordspan').html("<img src=images/tick.png alt=zubair height=15 width=15 />").removeClass("colourchangingofname");
                   $("#password").css({
                       'border': '3px solid green'
                   })
                   $('input[type="submit"]').attr('disabled', false);

               }
               else {
                   $('#paswordspan').html("Ensure string has <b>two uppercase</b> letters, Ensure string has <b>one special case</b> letter,Ensure string has <b>two digits</b>.</br>string has <b>three lowercase</b> letters.Ensure string is of length <b>8</b>.").addClass("colourchangingofname");
                   $("#password").css({
                       'border': '3px solid red'
                   })
                   $('input[type="submit"]').attr('disabled', true);


               }
           }


           
        





           $('#names').hover(function () {


               
            
               var n = $('#name').val();
               if (n.length > 3)
               {
                   $('#jbsj').html("");

               }
               else
               {
                   $('#jbsj').html("Please enter your name e.g <b> bobe</b>").addClass("clourchangeagainhover");
               }


           }).mouseout(function () {
               $('#jbsj').html("");
           })


           $('#name').change(function () {
               var x = $('#name').val();
               if (x.length > 10) {
                   $('#showingerrors').html("Only 10 Characters are allowed !").addClass("colourchangingofname");
                   $('#name').css({
                       'border': '3px solid red'

                   })
                   $('input[type="submit"]').attr('disabled', true);
                   // alert("error");

               }
               else {
                   $('#showingerrors').html("").removeClass("colourchangingofname");
                   $('#name').css({
                       'border': '3px solid Green'

                   })
                   

                   $('input[type="submit"]').attr('disabled', false);
                   //alert("no issue");
               }
              

           })

           //var x = $('#name').val();
           //if (x.length = 0) {
           //    $('input[type="submit"]').attr('disabled', true);
           //} else {
           //    $('input[type="submit"]').attr('disabled', true);
           //}

         
       });
