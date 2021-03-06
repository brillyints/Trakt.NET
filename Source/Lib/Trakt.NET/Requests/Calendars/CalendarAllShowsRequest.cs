﻿namespace TraktNet.Requests.Calendars
{
    using Objects.Get.Calendars;

    internal sealed class CalendarAllShowsRequest : ACalendarRequest<ITraktCalendarShow>
    {
        public override string UriTemplate => "calendars/all/shows{/start_date}{/days}{?extended,query,years,genres,languages,countries,runtimes,ratings}";
    }
}
