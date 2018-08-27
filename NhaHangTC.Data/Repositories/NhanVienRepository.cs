using NhaHangTC.Data.Infrastructure;
using NhaHangTC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NhaHangTC.Data.Repositories
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
        IEnumerable<NhanVien> GetListNhanVienByCV(string tencv, int page, int pageSize, out int totalRow);
    }
    public class NhanVienRepository : RepositoryBase<Ban>, INhanVienRepository
    {
        public NhanVienRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        //public NhanVien Add(NhanVien entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CheckContains(Expression<Func<NhanVien, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public int Count(Expression<Func<NhanVien, bool>> where)
        //{
        //    throw new NotImplementedException();
        //}

        //public NhanVien Delete(NhanVien entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteMulti(Expression<Func<NhanVien, bool>> where)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<NhanVien> GetListNhanVienByCV(string tencv, int page, int pageSize, out int totalRow)
        {
            var query = from nv in DbContext.NhanViens
                        join cv in DbContext.ChucVus
                        on nv.MACV equals cv.MACV
                        where cv.TENCV == tencv
                        select nv;
            totalRow = query.Count();

            return query.OrderByDescending(x => x.MANV).Skip((page - 1) * pageSize).Take(pageSize);
            throw new NotImplementedException();
        }

        //public IEnumerable<NhanVien> GetMulti(Expression<Func<NhanVien, bool>> predicate, string[] includes = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<NhanVien> GetMultiPaging(Expression<Func<NhanVien, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public NhanVien GetSingleByCondition(Expression<Func<NhanVien, bool>> expression, string[] includes = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(NhanVien entity)
        //{
        //    throw new NotImplementedException();
        //}

        //NhanVien IRepository<NhanVien>.Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //IEnumerable<NhanVien> IRepository<NhanVien>.GetAll(string[] includes)
        //{
        //    throw new NotImplementedException();
        //}

        //NhanVien IRepository<NhanVien>.GetSingleById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
