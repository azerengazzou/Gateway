namespace GatewayAPI
{
    public class JwtRolesMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtRolesMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
                var roles = context.User.Claims
                                   .Where(c => c.Type == "role")
                                   .Select(c => c.Value)
                                   .ToList();
                // Log the extracted roles
                foreach (var role in roles)
                {
                    Console.WriteLine("Extracted role: !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + role);
                }

                // Store the extracted roles in a suitable location (e.g., HttpContext.Items)
                context.Items["UserRoles"] = roles;

            await _next.Invoke(context);
        }

    }
}
