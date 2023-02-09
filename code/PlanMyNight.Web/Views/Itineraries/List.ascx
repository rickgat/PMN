<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<ItineraryViewModel>>" %>
<ul class="itineraries">
<% foreach(var itinerary in Model) %>
<% { %>
    <li>
        <span style="float:right" class="rating <%=ItineraryHelper.GetRatingCssClass(itinerary.Rating)%>"><span>Rating: <%=ItineraryHelper.GetRatingLabel(itinerary.Rating)%></span></span>
        <a href="<%=Html.AttributeEncode(itinerary.DetailsLink)%>"><%:itinerary.Name%></a> (<%=itinerary.ActivitiesCount%> activities)
    </li>
<% } %>
</ul>