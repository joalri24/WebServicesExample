﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HeroesController : ApiController
    {
        private WebApiServicesContext db = new WebApiServicesContext();

        // GET: api/Heroes
        public IQueryable<Hero> GetHeroes()
        {
            return db.Heroes;
        }

        // GET: api/Heroes/5
        [ResponseType(typeof(Hero))]
        public async Task<IHttpActionResult> GetHero(int id)
        {
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // PUT: api/Heroes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutHero(int id, Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hero.Id)
            {
                return BadRequest();
            }

            db.Entry(hero).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Heroes
        [ResponseType(typeof(Hero))]
        public async Task<IHttpActionResult> PostHero(Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Heroes.Add(hero);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = hero.Id }, hero);
        }

        // DELETE: api/Heroes/5
        [ResponseType(typeof(Hero))]
        public async Task<IHttpActionResult> DeleteHero(int id)
        {
            Hero hero = await db.Heroes.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }

            db.Heroes.Remove(hero);
            await db.SaveChangesAsync();

            return Ok(hero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HeroExists(int id)
        {
            return db.Heroes.Count(e => e.Id == id) > 0;
        }
    }
}