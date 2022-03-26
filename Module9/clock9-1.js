"use strict"

/*
   New Perspectives on HTML5 and CSS3, 8th Edition
   Tutorial 9
   Coding Challenge 1

   Clock
   Author: Alexander Overley
   Date:  07/02/2020 

   function getWeekday(dayNum)
      Returns the text of the day of the week where dayNum
      is the number of the week from 0 (Sunday) to 6 (Saturday)
*/


function getWeekday(dayNum) {
   var wDays = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
   return wDays[dayNum];
}

runClock();
setInterval(runClock(), 3000);


function runClock(){
  var thisDay = new Date();

  var thisDate = thisDay.toLocaleDateString();

  var thisDayNum = getWeekday(thisDayNum);

  var thisWeekday = getWeekday(thisDayNum);

  var thisTime = thisDay.toLocaleDateString();

  document.getElementById("date").textContent = thisDate;
  document.getElementById("wday").textContent = thisWeekday; 
  document.getElementById("time").textContent = thisTime; 

} 
