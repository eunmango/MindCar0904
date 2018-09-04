var CarControl1 : GameObject;
var CarControl2 : GameObject;
function Start(){

    CarControl1.GetComponent("SportCar_1_Controller_com").enabled = true; 
    CarControl2.GetComponent("SportCar_2_Controller_com").enabled = true;
}
