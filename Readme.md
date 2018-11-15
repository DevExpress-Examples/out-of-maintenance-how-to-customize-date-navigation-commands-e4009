<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# How to customize date navigation commands


<p>By default, <a href="http://documentation.devexpress.com/#AspNet/CustomDocument3832"><u>View Navigator</u></a> forward and backward buttons behavior in Timeline view causes the left-most and right-most time cells to be still visible when navigating backward and forward correspondingly. You can easily modify this behavior by overriding <strong>NavigateForwardCallbackCommand </strong>and <strong>NavigateBackwardCallbackCommand</strong> <a href="http://documentation.devexpress.com/#AspNet/CustomDocument5462"><u>Callback Commands</u></a> in the manner shown in this example.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E497">How to show the entire month in the MonthView</a></p>


<h3>Description</h3>

<p>Since the default date navigation behavior of the Timeline&nbsp;view was changed (<a data-ticket="T184083">T184083: In TimeLineView mode navigation works incorrectly if the IntervalCount property has the 29 value</a>),&nbsp;this&nbsp;example also shows how to&nbsp;turn&nbsp;back the old behavior starting with the 14.1.9 minor version.</p>

<br/>


