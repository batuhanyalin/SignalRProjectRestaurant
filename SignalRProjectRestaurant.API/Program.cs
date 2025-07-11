using SignalR.BusinessLayer.Abstract;
using SignalR.BusinessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
using SignalR.DataAccessLayer.EntityFramework;
using SignalRProjectRestaurant.API.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProjectContext>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .SetIsOriginAllowed((host) => true);
    });
});
builder.Services.AddSignalR();


builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDAL, EFBookingDAL>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();

builder.Services.AddScoped<IContactUsService, ContactUsManager>();
builder.Services.AddScoped<IContactUsDAL, EFContactUsDAL>();

builder.Services.AddScoped<IDiscountService, DiscountManager>();
builder.Services.AddScoped<IDiscountDAL, EFDiscountDAL>();

builder.Services.AddScoped<IOpenHoursService, OpenHoursManager>();
builder.Services.AddScoped<IOpenHoursDAL, EFOpenHoursDAL>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDAL, EFProductDAL>();

builder.Services.AddScoped<ISliderService, SliderManager>();
builder.Services.AddScoped<ISliderDAL, EFSliderDAL>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();

builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();

builder.Services.AddScoped<IOrderService, OrderManager>();
builder.Services.AddScoped<IOrderDAL, EFOrderDAL>();

builder.Services.AddScoped<IOrderDetailService, OrderDetailManager>();
builder.Services.AddScoped<IOrderDetailDAL, EFOrderDetailDAL>();

builder.Services.AddScoped<IMoneyCaseService, MoneyCaseManager>();
builder.Services.AddScoped<IMoneyCaseDAL, EFMoneyCaseDAL>();

builder.Services.AddScoped<IClientTableService, ClientTableManager>();
builder.Services.AddScoped<IClientTableDAL, EFClientTableDAL>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");
app.Run();
