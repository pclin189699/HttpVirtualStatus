using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace HttpVirtualStatus.Controllers
{
    [Route("api/[controller]/{statusCode}")]
    [ApiController]
    public class VirtualStatusController : ControllerBase
    {
        [HttpGet(Name = "VirtualCode")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status100Continue)]
        [ProducesResponseType(StatusCodes.Status101SwitchingProtocols)]
        [ProducesResponseType(StatusCodes.Status102Processing)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status203NonAuthoritative)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status205ResetContent)]
        [ProducesResponseType(StatusCodes.Status206PartialContent)]
        [ProducesResponseType(StatusCodes.Status207MultiStatus)]
        [ProducesResponseType(StatusCodes.Status208AlreadyReported)]
        [ProducesResponseType(StatusCodes.Status226IMUsed)]
        [ProducesResponseType(StatusCodes.Status300MultipleChoices)]
        [ProducesResponseType(StatusCodes.Status301MovedPermanently)]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(StatusCodes.Status303SeeOther)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        [ProducesResponseType(StatusCodes.Status305UseProxy)]
        [ProducesResponseType(StatusCodes.Status306SwitchProxy)]
        [ProducesResponseType(StatusCodes.Status307TemporaryRedirect)]
        [ProducesResponseType(StatusCodes.Status308PermanentRedirect)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status402PaymentRequired)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        [ProducesResponseType(StatusCodes.Status407ProxyAuthenticationRequired)]
        [ProducesResponseType(StatusCodes.Status408RequestTimeout)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status410Gone)]
        [ProducesResponseType(StatusCodes.Status411LengthRequired)]
        [ProducesResponseType(StatusCodes.Status412PreconditionFailed)]
        [ProducesResponseType(StatusCodes.Status413RequestEntityTooLarge)]
        [ProducesResponseType(StatusCodes.Status414RequestUriTooLong)]
        [ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
        [ProducesResponseType(StatusCodes.Status416RequestedRangeNotSatisfiable)]
        [ProducesResponseType(StatusCodes.Status417ExpectationFailed)]
        [ProducesResponseType(StatusCodes.Status418ImATeapot)]
        [ProducesResponseType(StatusCodes.Status419AuthenticationTimeout)]
        [ProducesResponseType(StatusCodes.Status421MisdirectedRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status423Locked)]
        [ProducesResponseType(StatusCodes.Status424FailedDependency)]
        [ProducesResponseType(StatusCodes.Status426UpgradeRequired)]
        [ProducesResponseType(StatusCodes.Status428PreconditionRequired)]
        [ProducesResponseType(StatusCodes.Status429TooManyRequests)]
        [ProducesResponseType(StatusCodes.Status431RequestHeaderFieldsTooLarge)]
        [ProducesResponseType(StatusCodes.Status451UnavailableForLegalReasons)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status501NotImplemented)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        [ProducesResponseType(StatusCodes.Status505HttpVersionNotsupported)]
        [ProducesResponseType(StatusCodes.Status506VariantAlsoNegotiates)]
        [ProducesResponseType(StatusCodes.Status507InsufficientStorage)]
        [ProducesResponseType(StatusCodes.Status508LoopDetected)]
        [ProducesResponseType(StatusCodes.Status510NotExtended)]
        [ProducesResponseType(StatusCodes.Status511NetworkAuthenticationRequired)]
        public IActionResult Get(int statusCode)
        {
            switch (statusCode)
            {
                case StatusCodes.Status100Continue:
                    return StatusCode(StatusCodes.Status100Continue);
                case StatusCodes.Status101SwitchingProtocols:
                    return StatusCode(StatusCodes.Status101SwitchingProtocols);
                case StatusCodes.Status102Processing:
                    return StatusCode(StatusCodes.Status102Processing);
                case StatusCodes.Status200OK:
                    return Ok(); //return StatusCode(StatusCodes.Status200OK);
                case StatusCodes.Status201Created:
                    return StatusCode(StatusCodes.Status201Created);
                case StatusCodes.Status202Accepted:
                    return StatusCode(StatusCodes.Status202Accepted);
                case StatusCodes.Status203NonAuthoritative:
                    return StatusCode(StatusCodes.Status203NonAuthoritative);
                case StatusCodes.Status204NoContent:
                    return StatusCode(StatusCodes.Status204NoContent);
                case StatusCodes.Status205ResetContent:
                    return StatusCode(StatusCodes.Status205ResetContent);
                case StatusCodes.Status206PartialContent:
                    return StatusCode(StatusCodes.Status206PartialContent);
                case StatusCodes.Status207MultiStatus:
                    return StatusCode(StatusCodes.Status207MultiStatus);
                case StatusCodes.Status208AlreadyReported:
                    return StatusCode(StatusCodes.Status208AlreadyReported);
                case StatusCodes.Status226IMUsed:
                    return StatusCode(StatusCodes.Status226IMUsed);
                case StatusCodes.Status300MultipleChoices:
                    return StatusCode(StatusCodes.Status300MultipleChoices);
                case StatusCodes.Status301MovedPermanently:
                    return StatusCode(StatusCodes.Status301MovedPermanently);
                case StatusCodes.Status302Found:
                    return StatusCode(StatusCodes.Status302Found);
                case StatusCodes.Status303SeeOther:
                    return StatusCode(StatusCodes.Status303SeeOther);
                case StatusCodes.Status304NotModified:
                    return StatusCode(StatusCodes.Status304NotModified);
                case StatusCodes.Status305UseProxy:
                    return StatusCode(StatusCodes.Status305UseProxy);
                case StatusCodes.Status306SwitchProxy:
                    return StatusCode(StatusCodes.Status306SwitchProxy);
                case StatusCodes.Status307TemporaryRedirect:
                    return StatusCode(StatusCodes.Status307TemporaryRedirect);
                case StatusCodes.Status308PermanentRedirect:
                    return StatusCode(StatusCodes.Status308PermanentRedirect);
                case StatusCodes.Status400BadRequest:
                    return StatusCode(StatusCodes.Status400BadRequest);
                case StatusCodes.Status401Unauthorized:
                    return StatusCode(StatusCodes.Status401Unauthorized);
                case StatusCodes.Status402PaymentRequired:
                    return StatusCode(StatusCodes.Status402PaymentRequired);
                case StatusCodes.Status403Forbidden:
                    return StatusCode(StatusCodes.Status403Forbidden);
                case StatusCodes.Status404NotFound:
                    return StatusCode(StatusCodes.Status404NotFound);
                case StatusCodes.Status405MethodNotAllowed:
                    return StatusCode(StatusCodes.Status405MethodNotAllowed);
                case StatusCodes.Status406NotAcceptable:
                    return StatusCode(StatusCodes.Status406NotAcceptable);
                case StatusCodes.Status407ProxyAuthenticationRequired:
                    return StatusCode(StatusCodes.Status407ProxyAuthenticationRequired);
                case StatusCodes.Status408RequestTimeout:
                    return StatusCode(StatusCodes.Status408RequestTimeout);
                case StatusCodes.Status409Conflict:
                    return StatusCode(StatusCodes.Status409Conflict);
                case StatusCodes.Status410Gone:
                    return StatusCode(StatusCodes.Status410Gone);
                case StatusCodes.Status411LengthRequired:
                    return StatusCode(StatusCodes.Status411LengthRequired);
                case StatusCodes.Status412PreconditionFailed:
                    return StatusCode(StatusCodes.Status412PreconditionFailed);
                case StatusCodes.Status413RequestEntityTooLarge:
                    return StatusCode(StatusCodes.Status413RequestEntityTooLarge);
                case StatusCodes.Status414RequestUriTooLong:
                    return StatusCode(StatusCodes.Status414RequestUriTooLong);
                case StatusCodes.Status415UnsupportedMediaType:
                    return StatusCode(StatusCodes.Status415UnsupportedMediaType);
                case StatusCodes.Status416RequestedRangeNotSatisfiable:
                    return StatusCode(StatusCodes.Status416RequestedRangeNotSatisfiable);
                case StatusCodes.Status417ExpectationFailed:
                    return StatusCode(StatusCodes.Status417ExpectationFailed);
                case StatusCodes.Status418ImATeapot:
                    return StatusCode(StatusCodes.Status418ImATeapot);
                case StatusCodes.Status419AuthenticationTimeout:
                    return StatusCode(StatusCodes.Status419AuthenticationTimeout);
                case StatusCodes.Status421MisdirectedRequest:
                    return StatusCode(StatusCodes.Status421MisdirectedRequest);
                case StatusCodes.Status422UnprocessableEntity:
                    return StatusCode(StatusCodes.Status422UnprocessableEntity);
                case StatusCodes.Status423Locked:
                    return StatusCode(StatusCodes.Status423Locked);
                case StatusCodes.Status424FailedDependency:
                    return StatusCode(StatusCodes.Status424FailedDependency);
                case StatusCodes.Status426UpgradeRequired:
                    return StatusCode(StatusCodes.Status426UpgradeRequired);
                case StatusCodes.Status428PreconditionRequired:
                    return StatusCode(StatusCodes.Status428PreconditionRequired);
                case StatusCodes.Status429TooManyRequests:
                    return StatusCode(StatusCodes.Status429TooManyRequests);
                case StatusCodes.Status431RequestHeaderFieldsTooLarge:
                    return StatusCode(StatusCodes.Status431RequestHeaderFieldsTooLarge);
                case StatusCodes.Status451UnavailableForLegalReasons:
                    return StatusCode(StatusCodes.Status451UnavailableForLegalReasons);
                case StatusCodes.Status500InternalServerError:
                    return StatusCode(StatusCodes.Status500InternalServerError);
                case StatusCodes.Status501NotImplemented:
                    return StatusCode(StatusCodes.Status501NotImplemented);
                case StatusCodes.Status502BadGateway:
                    return StatusCode(StatusCodes.Status502BadGateway);
                case StatusCodes.Status503ServiceUnavailable:
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                case StatusCodes.Status504GatewayTimeout:
                    return StatusCode(StatusCodes.Status504GatewayTimeout);
                case StatusCodes.Status505HttpVersionNotsupported:
                    return StatusCode(StatusCodes.Status505HttpVersionNotsupported);
                case StatusCodes.Status506VariantAlsoNegotiates:
                    return StatusCode(StatusCodes.Status506VariantAlsoNegotiates);
                case StatusCodes.Status507InsufficientStorage:
                    return StatusCode(StatusCodes.Status507InsufficientStorage);
                case StatusCodes.Status508LoopDetected:
                    return StatusCode(StatusCodes.Status508LoopDetected);
                case StatusCodes.Status510NotExtended:
                    return StatusCode(StatusCodes.Status510NotExtended);
                case StatusCodes.Status511NetworkAuthenticationRequired:
                    return StatusCode(StatusCodes.Status511NetworkAuthenticationRequired);
                default:
                    return BadRequest(string.Format("Invalid status code: {0}, AspNetCore not defined!", statusCode));
            }
        }
    }
}
