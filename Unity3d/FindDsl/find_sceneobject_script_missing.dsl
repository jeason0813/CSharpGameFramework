input("Transform")
{
	string("filter", "");
	feature("source", "sceneobjects");
}
filter
{   
	if(scenepath.Contains(filter)){
	  var(0) = getcomponents(object, "Component");
	  var(1) = 0;
	  looplist(var(0)){
	    if(isnull($$)){
	      var(1)=1;
	    };
	  };
	  var(1);
	}else{
	  0;
	};
};