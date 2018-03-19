function LoadNewPerson(personName)
{
	var frame = document.getElementById("FrameContent");
	
	if (personName === "Andreas_A")
	{
		LoadCSS("Andreas_ASelected");
	}
	else if (personName === "Andreas_H")
	{
		LoadCSS("Andreas_HSelected");
	}
	else if (personName === "Jimmy")
	{
		LoadCSS("JimmySelected");
	}
	else if (personName === "Victor")
	{
		LoadCSS("VictorSelected");
	}
	else
	{
		LoadCSS("GruppSelected");
	}
}

function LoadCSS(map)
{
	document.getElementsByTagName("body")[0].setAttribute("class", map);
}

function LoadAndreas_A()
{
	LoadNewPerson("Andreas_A");
}
function LoadAndreas_H()
{
	LoadNewPerson("Andreas_H");
}
function LoadVictor()
{
	LoadNewPerson("Victor");
}
function LoadJimmy()
{
	LoadNewPerson("Jimmy");
}
