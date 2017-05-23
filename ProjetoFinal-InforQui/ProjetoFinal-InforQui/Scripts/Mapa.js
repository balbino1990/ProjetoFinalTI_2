function initialize() {
    var mapOptions = {
        center: new google.maps.LatLng('@latitude', '@longitude'),
        zoom: 17,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map_canvas"),
      mapOptions);
    // create a marker  
    var latlng = new google.maps.LatLng('@latitude', '@longitude');
    var marker = new google.maps.Marker({
        position: latlng,
        map: map,
        title: 'Latitude: ' + latlng.Ya + ' Longitude :' + latlng.Za,
        draggable: true
    });
    infoWindow = new google.maps.InfoWindow({
        content: ""
    });
    infoWindow.open(map, marker);
    geocoder = new google.maps.Geocoder();
    //Update postal address when the marker is dragged  
    google.maps.event.addListener(marker, 'click', function () { //dragend  
        geocoder.geocode({ latLng: marker.getPosition() }, function (responses) {
            if (responses && responses.length > 0) {
                infoWindow.setContent(
                "<div style=\"font-size:smaller;\">" + responses[0].formatted_address
                + "<br />"
                + "Latitude: " + marker.getPosition().lat() + "&nbsp"
                + "Longitude: " + marker.getPosition().lng() + "</div>"
                );
                infoWindow.open(map, marker);
            } else {
                alert('Error: Google Maps could not determine the address of this location.');
            }
        });
        map.panTo(marker.getPosition());
    });
    // Close the marker window when being dragged  
    google.maps.event.addListener(marker, 'dragstart', function () {
        infoWindow.close(map, marker);
    });
}
