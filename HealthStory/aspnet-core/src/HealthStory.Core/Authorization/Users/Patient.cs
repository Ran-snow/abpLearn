using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthStory.Authorization.Users
{
    [Table("h_patient")]
    public class Patient : Entity, IHasCreationTime
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string PatientName { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [Required]
        [RegularExpression(@"1\d{10}")]
        [StringLength(11)]
        public string Phone { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [Required]
        [RegularExpression(@"\d{15}(\d\d[0-9xX])?")]
        [StringLength(18)]
        public string IDCard { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        DateTime BirthFate { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [MaxLength(20)]
        public string People { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }

        /// <summary>
        /// 家乡
        /// </summary>
        [MaxLength(200)]
        public string Hometown { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public double BodyHeight { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public double BodyWeight { get; set; }
    }
}
