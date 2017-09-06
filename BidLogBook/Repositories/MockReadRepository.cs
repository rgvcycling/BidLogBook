using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BidLogBook.Entities;

namespace BidLogBook.Repositories
{
    public class MockReadRepository : IReadRepository
    {
        #region Mock Data
        List<LogBook> _bidLogBooks = new List<LogBook>
        {
            new LogBook{ LogId = 1, DateReceived="08/10/2017", TimeReceived="9:57 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Kay/Bassman International",OpeningDate=Convert.ToDateTime("08/10/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 2, DateReceived="08/10/2017", TimeReceived="9:55 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Witt/Kieffer",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 3, DateReceived="08/10/2017", TimeReceived="9:07 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Korn Ferry",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 4, DateReceived="08/10/2017", TimeReceived="8:22 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Whekess Partners",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 5, DateReceived="08/09/2017", TimeReceived="8:03 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Russel Reynolds Associates",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }

            new LogBook{ LogId = 6, DateReceived="08/09/2017", TimeReceived="11:49 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Kay/Bassman International",OpeningDate=Convert.ToDateTime("08/10/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 7, DateReceived="08/09/2017", TimeReceived="10:26 AM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Witt/Kieffer",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 8, DateReceived="08/08/2017", TimeReceived="4:10 PM", Late="No", IFBNo="PROVOST/VPAA SEARCH",VendorName="Korn Ferry",OpeningDate=Convert.ToDateTime("01/05/2017"),OpeningTime="10:00 AM",Buyer="Marilu Reyes",DeliveryMethod="eMail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 9, DateReceived="08/03/2017", TimeReceived="8:20 AM", Late="No", IFBNo="17-JE-02",VendorName="El Expreso Group",OpeningDate=Convert.ToDateTime("08/03/2017"),OpeningTime="11:00 AM",Buyer="Jerry Escobedo",DeliveryMethod="Mail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }
            new LogBook{ LogId = 10, DateReceived="08/02/2017", TimeReceived="4:00 PM", Late="No", IFBNo="17-JE-02",VendorName="Echo Tours & Charters LLC",OpeningDate=Convert.ToDateTime("08/03/2017"),OpeningTime="11:00 AM",Buyer="Jerry Escobedo",DeliveryMethod="Mail",Notes="my notes",ReceivedBy="Stephanie Vasquez",CreatedBy="Stephanie Vasquez", CreatedOn=Convert.ToDateTime("01/01/2017"),ModifiedBy="",ModifiedOn=null }


        };
    }
}
