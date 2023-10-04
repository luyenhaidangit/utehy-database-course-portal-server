﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Twilio.Http;
using UTEHY.DatabaseCoursePortal.Api.Constants;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;
using UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore;
using UTEHY.DatabaseCoursePortal.Api.Models.Banner;
using UTEHY.DatabaseCoursePortal.Api.Models.Common;

namespace UTEHY.DatabaseCoursePortal.Api.Services
{
    public class BannerService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileService _fileService;
        private readonly IMapper _mapper;

        public BannerService(ApplicationDbContext dbContext, FileService fileService,IMapper mapper)
        {
            _dbContext = dbContext;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<PageResult<Banner>> Get(GetBannerRequest request)
        {
            var query = _dbContext.Banners.AsQueryable();

            if (!string.IsNullOrEmpty(request.Type))
            {
                query = query.Where(b => b.Type == request.Type);
            }

            if (!string.IsNullOrEmpty(request.Place))
            {
                query = query.Where(b => b.Place == request.Place);
            }

            int total = await query.CountAsync();

            if (request.PageIndex == null) request.PageIndex = 1;
            if (request.PageSize == null) request.PageSize = total;

            int totalPages = (int)Math.Ceiling((double)total / request.PageSize.Value);

            var items = await query
            .OrderByDescending(b => b.Priority)
            .Skip((request.PageIndex.Value - 1) * request.PageSize.Value)
            .Take(request.PageSize.Value)
            .ToListAsync();

            var result = new PageResult<Banner>(items,request.PageIndex.Value,request.PageSize.Value,total,totalPages);

            return result;
        }

        public async Task<Banner> Create(CreateBannerRequest request)
        {
            request.Image = await _fileService.UploadFile(request.ImageFile, PathFolder.Banner);
            var banner = _mapper.Map<Banner>(request);

            await _dbContext.Banners.AddAsync(banner);
            await _dbContext.SaveChangesAsync();

            return banner;
        }
    }
}
