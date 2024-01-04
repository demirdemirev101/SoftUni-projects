function attachEvents() {
    const button=document.querySelector("#submit");
    button.addEventListener('click', getWeather);
}


const conditions={
        
    'Sunny': '☀',
    'Partly sunny': '⛅',
    'Overcast': '☁',
    'Rain': '☂',
};


async function getWeather(){
    const responseName= await (await fetch("http://localhost:3030/jsonstore/forecaster/locations"))
    .json();
    
    const locationName=document.querySelector("#location").value;
    const locationObj=responseName.find((l)=>l.name===locationName)
   

    const code=locationObj.code;
    forecastResponse= await( await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`))
    .json();
    
    forecastThreeDaysResponse= await( await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`))
    .json();

    document.querySelector("#forecast").style.display='block';

// Current forecast

    const currentForecast=document.querySelector("#current");

    const forecasts=document.createElement('div');
    forecasts.className="forecasts";


    const conditionSymbol=document.createElement('span');
    conditionSymbol.classList.add("condition", "symbol");
    conditionSymbol.textContent=conditions[forecastResponse.forecast.condition];

    
    const currentCondition =document.createElement('span');
    currentCondition.className='condition';

    const forecastName = document.createElement('span');
    forecastName.className='forecast-data';
    forecastName.textContent=forecastResponse.name;
    
    const forecastTemp = document.createElement('span');
    forecastTemp.className='forecast-data';
    forecastTemp.textContent=`${forecastResponse.forecast.low}°/${forecastResponse.forecast.high}°`;

    const forecastCondition = document.createElement('span');
    forecastCondition.className='forecast-data';
    forecastCondition.textContent=forecastResponse.forecast.condition;

    currentCondition.appendChild(forecastName);
    currentCondition.appendChild(forecastTemp);
    currentCondition.appendChild(forecastCondition);

    forecasts.appendChild(conditionSymbol);
    forecasts.appendChild(currentCondition);
    currentForecast.appendChild(forecasts);


// Three day forecast

    const upcomingForecast=document.querySelector("#upcoming");
    
    const upcomingForecastInfo=document.createElement('div');
    upcomingForecastInfo.classList.add("forecast-info");

//FIRST CARD

    const upcomingCardOne=document.createElement('span');
    upcomingCardOne.classList.add("upcoming");

    const symbol=document.createElement('span');
    symbol.classList.add('symbol');
    symbol.textContent=conditions[forecastThreeDaysResponse.forecast[0].condition];
    
    const upcomingForecastTemp=document.createElement('span');
    upcomingForecastTemp.classList.add('forecast-data');
    upcomingForecastTemp.textContent=`${forecastThreeDaysResponse.forecast[0].low}°/${forecastThreeDaysResponse.forecast[0].high}°`;
    
    const upcomingForecastCondition=document.createElement('span');
    upcomingForecastCondition.classList.add('forecast-data');
    upcomingForecastCondition.textContent=forecastThreeDaysResponse.forecast[0].condition;
    
    
    upcomingCardOne.appendChild(symbol);
    upcomingCardOne.appendChild(upcomingForecastTemp);
    upcomingCardOne.appendChild(upcomingForecastCondition);

//SSECOND CARD

    const upcomingCardSecond=document.createElement('span');
    upcomingCardSecond.classList.add("upcoming");

    const symbolSecond=document.createElement('span');
    symbolSecond.classList.add('symbol');
    symbolSecond.textContent=conditions[forecastThreeDaysResponse.forecast[1].condition];
    
    const upcomingForecastTempSecond=document.createElement('span');
    upcomingForecastTempSecond.classList.add('forecast-data');
    upcomingForecastTempSecond.textContent=`${forecastThreeDaysResponse.forecast[1].low}°/${forecastThreeDaysResponse.forecast[1].high}°`;
    
    const upcomingForecastConditionSecond=document.createElement('span');
    upcomingForecastConditionSecond.classList.add('forecast-data');
    upcomingForecastConditionSecond.textContent=forecastThreeDaysResponse.forecast[1].condition;
    
    
    upcomingCardSecond.appendChild(symbolSecond);
    upcomingCardSecond.appendChild(upcomingForecastTempSecond);
    upcomingCardSecond.appendChild(upcomingForecastConditionSecond);

//THIRD CARD

    const upcomingCardThird=document.createElement('span');
    upcomingCardThird.classList.add("upcoming");

    const symbolThird=document.createElement('span');
    symbolThird.classList.add('symbol');
    symbolThird.textContent=conditions[forecastThreeDaysResponse.forecast[2].condition];

    const upcomingForecastTempThird=document.createElement('span');
    upcomingForecastTempThird.classList.add('forecast-data');
    upcomingForecastTempThird.textContent=`${forecastThreeDaysResponse.forecast[2].low}°/${forecastThreeDaysResponse.forecast[2].high}°`;

    const upcomingForecastConditionThird=document.createElement('span');
    upcomingForecastConditionThird.classList.add('forecast-data');
    upcomingForecastConditionThird.textContent=forecastThreeDaysResponse.forecast[2].condition;


    upcomingCardThird.appendChild(symbolThird);
    upcomingCardThird.appendChild(upcomingForecastTempThird);
    upcomingCardThird.appendChild(upcomingForecastConditionThird);

//Appending the cards to the upcoming class and apppending the class to the forecast div

    upcomingForecastInfo.appendChild(upcomingCardOne);
    upcomingForecastInfo.appendChild(upcomingCardSecond);
    upcomingForecastInfo.appendChild(upcomingCardThird);

    upcomingForecast.appendChild(upcomingForecastInfo);
}
attachEvents();