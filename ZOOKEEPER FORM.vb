<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Zoo Keeper Form</title>
    <link rel="stylesheet" href="style9.css">
</head>
<body>
    <div class="container">
        <form>
    <h1 style="font-weight: bold;">Zoo Keeper Application Form</h1>
    <p style="font-weight: bold;"><i>Please complete the form.Mandatory fields are marked with a *</i></p>
    <fieldset>
        <legend class="boldd">CONTACT DETAILS</legend>
        <p>Name*<input type="text" name="name"  required></p>
        <p>Phone<input type="number" name="telephone"></p>
        <p>Email*<input type="email" name="email"></p>
    </fieldset>
    <fieldset>
        <legend class="boldd">Personal Information</legend>
        <p> Gender
        <select name="gender" id="gender">
            <option value="">Female </option>
            <option value="Female">Female</option>
            <option value="Mail">Mail</option>
         </select>
        </p>
        <p> When did you
            <br> 
            first know you wanted to be a zoo-keeper?
             <textarea name= "answer" id="answer" cols="100" rows="10"></textarea>
        </p>
    </fieldset>
    <br>
    <fieldset>
         <table cellpadding='5' width='600'> 
             <tr>
                 <td>
        <legend class="boldd">PICK YOUR FAVORITE ANIMALS</legend>
        <input type='checkbox' value='Zebra' name='Zebra' />
        <label  for ='Zebra'>Zebra</label>
        <input type='checkbox' value='Cat' name='Cat' />  
        <label  for='Cat'>Cat</label>
        <input type='checkbox' value='Anaconda' name='Anaconda' />  
        <label  for='Anaconda'>Anaconda</label>
        <input type='checkbox' value='Human' name='Human' /> 
        <label  for='Human'>Human</label>
                 </td>

        </tr>
        <br>
        <tr>
        <td>
        <input type='checkbox' value='Elephant' name='Elephant' />  
        <label  for='Elephant'>Elephant</label>
        <input type='checkbox' value='Wildebeest' name='Wildebeest' />  
        <label  for='Wildebeest'>Wildebeest</label>
        <input type='checkbox' value='Pigeon' name='Pigeon' /> 
         <label  for='Pigeon'>Pigeon</label>
        <input type='checkbox'value='Crab' name='Crab' /> 
         <label  for='Crab'>Crab</label>
         </td>
         </tr>
         </table>
    </fieldset>
    <br>
    <p class="abc">
    <input type='Submit' Value='Submit Application'  style="background-color: blanchedalmond;"/>
</p>
    
</form>
    </div>
</body>
</html>