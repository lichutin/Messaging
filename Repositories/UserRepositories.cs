﻿using System.Collections.Generic;
using System.Linq;
using DataBaseModel;
using DomainEntities;

namespace Repositories
{
    /// <summary>
    /// Репозитории для пользователей
    /// </summary>
    public class UserRepositories : IUserRepositories
    {
        #region Constructor & properties

        /// <summary>
        /// Контекст для работы с БД
        /// </summary>
        private readonly IContext<MembershipUser> _context;

        public UserRepositories(IContext<MembershipUser> context)
        {
            _context = context;
        }

        #endregion Constructor & properties

        #region Methods

        /// <summary>
        /// Получить пользователя по id
        /// </summary>
        public MembershipUser GetById(string id)
        {
            return _context.Table.FirstOrDefault(n => n.Id == id);
        }

        /// <summary>
        /// Получить список пользователей для отправки сообщений
        /// </summary>
        public IEnumerable<MembershipUser> GetUsersForSendMessage()
        {
            return _context.Table.ToList();
        }

        #endregion Methods
    }
}
