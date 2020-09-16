using Ruanmou.Framework.Model;
using Ruanmou.Libraries.Model;
using System.Collections.Generic;

namespace Ruanmou.Libraries.IDAL
{
    public interface IBaseDAL
    {

        /// <summary>
        /// 约束是为了正确的调用，才能int id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        T Find<T>(int id) where T : BaseModel;

        List<T> FindAll<T>() where T : BaseModel;

        void Update<T>(T t) where T : BaseModel;

        /// <summary>
        /// 自己完成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void Insert<T>(T t) where T : BaseModel;
        /// <summary>
        /// 自己完成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        void Delete<T>(int id) where T : BaseModel;


    }
}
